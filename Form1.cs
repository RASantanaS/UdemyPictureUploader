using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace UdemyPictureUploader
{
    public partial class udemyPictureUploader : Form
    {
        public udemyPictureUploader()
        {
            InitializeComponent();
            this.FormClosing += UdemyPictureUploader_FormClosing;
        }

        private void UdemyPictureUploader_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener animación de GIFs al cerrar la forma
            if (imagen_PictureBox.Image != null)
            {
                ImageAnimator.StopAnimate(imagen_PictureBox.Image, OnFrameChanged);
            }
            LimpiarImagen();
        }

        private void udemyPictureUploader_Load(object sender, EventArgs e)
        {
            try
            {
                imagen_PictureBox.DataBindings.Clear();
                imagen_PictureBox.Image = null;

                this.udmImage_UploadsTableAdapter.Fill(this.udmImages.udmImage_Uploads);

                // Suscribirse al cambio de registro para cargar la imagen
                this.udmImage_UploadsBindingSource.CurrentChanged += CargarImagenDelRegistro;

                CargarImagenDelRegistro(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}", "Error");
            }
        }

        private void CargarImagenDelRegistro(object sender, EventArgs e)
        {
            try
            {
                // Detener animación anterior si existe
                if (imagen_PictureBox.Image != null)
                {
                    ImageAnimator.StopAnimate(imagen_PictureBox.Image, OnFrameChanged);
                }

                LimpiarImagen();

                if (this.udmImage_UploadsBindingSource.Current != null)
                {
                    DataRowView row = (DataRowView)this.udmImage_UploadsBindingSource.Current;

                    // Cargar desde el campo Imagen (BLOB)
                    if (row["Imagen:"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])row["Imagen:"];
                        if (imgBytes != null && imgBytes.Length > 0)
                        {
                            // Crear un MemoryStream persistente (Necesario para GIFs)
                            MemoryStream ms = new MemoryStream(imgBytes);

                            imagen_PictureBox.Image = Image.FromStream(ms);

                            // Si es GIF animado, iniciar animación
                            if (ImageAnimator.CanAnimate(imagen_PictureBox.Image))
                            {
                                ImageAnimator.Animate(imagen_PictureBox.Image, OnFrameChanged);
                            }
                            // El MemoryStream se limpia en LimpiarImagen()
                        }
                    }

                    if (row["Ruta de Imagen:"] != DBNull.Value)
                    {
                        ruta_de_Imagen_Label1.Text = row["Ruta de Imagen:"].ToString();
                    }
                    else
                    {
                        ruta_de_Imagen_Label1.Text = "Imagen desde base de datos";
                    }
                }
            }
            catch (Exception ex)
            {
                LimpiarImagen();
                ruta_de_Imagen_Label1.Text = $"Error: {ex.Message}";
            }
        }

        // Callback para actualizar frames de GIF animado
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (imagen_PictureBox.InvokeRequired)
            {
                imagen_PictureBox.BeginInvoke(new EventHandler(OnFrameChanged), sender, e);
            }
            else
            {
                imagen_PictureBox.Invalidate();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFd = new OpenFileDialog())
                {
                    openFd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFd.Title = "Seleccionar Imagen";

                    if (openFd.ShowDialog() == DialogResult.OK)
                    {
                        // Detener animación anterior
                        if (imagen_PictureBox.Image != null)
                        {
                            ImageAnimator.StopAnimate(imagen_PictureBox.Image, OnFrameChanged);
                        }

                        LimpiarImagen();

                        bool necesitaNuevoRegistro = true;

                        if (this.udmImage_UploadsBindingSource.Current != null)
                        {
                            DataRowView row = (DataRowView)this.udmImage_UploadsBindingSource.Current;

                            // Verificar si el registro actual ya tiene una imagen
                            if (row["Imagen:"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])row["Imagen:"];
                                if (imgBytes != null && imgBytes.Length > 0)
                                {
                                    // Preguntar al usuario si desea reemplazar o crear nuevo
                                    DialogResult resultado = MessageBox.Show(
                                        "El registro actual ya tiene una imagen. ¿Deseas reemplazarla?\n\n" +
                                        "Sí = Reemplazar imagen existente\n" +
                                        "No = Crear nuevo registro con esta imagen",
                                        "Imagen Existente",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Question);

                                    if (resultado == DialogResult.Cancel)
                                    {
                                        return;
                                    }
                                    else if (resultado == DialogResult.No)
                                    {
                                        necesitaNuevoRegistro = true;
                                    }
                                    else
                                    {
                                        necesitaNuevoRegistro = false;
                                    }
                                }
                                else
                                {
                                    necesitaNuevoRegistro = false; // Usar registro actual vacío
                                }
                            }
                            else
                            {
                                necesitaNuevoRegistro = false; // Usar registro actual vacío
                            }
                        }

                        // Crear nuevo registro si es necesario
                        if (necesitaNuevoRegistro || this.udmImage_UploadsBindingSource.Current == null)
                        {
                            this.udmImage_UploadsBindingSource.AddNew();
                        }

                        // Cargar directamente desde archivo para manejar GIFs correctamente
                        imagen_PictureBox.Image = Image.FromFile(openFd.FileName);

                        // Si es GIF animado, iniciar animación
                        if (ImageAnimator.CanAnimate(imagen_PictureBox.Image))
                        {
                            ImageAnimator.Animate(imagen_PictureBox.Image, OnFrameChanged);
                        }

                        ruta_de_Imagen_Label1.Text = openFd.FileName;

                        string nombreArchivo = Path.GetFileNameWithoutExtension(openFd.FileName);

                        // Actualizar el registro actual
                        if (this.udmImage_UploadsBindingSource.Current != null)
                        {
                            DataRowView row = (DataRowView)this.udmImage_UploadsBindingSource.Current;

                            if (row.Row.Table.Columns.Contains("Nombre:"))
                            {
                                row["Nombre:"] = nombreArchivo;
                            }

                            if (row.Row.Table.Columns.Contains("Ruta de Imagen:"))
                            {
                                row["Ruta de Imagen:"] = openFd.FileName;
                            }
                        }

                        MessageBox.Show("Imagen cargada. Presiona 'Guardar' para almacenarla permanentemente.",
                            "Imagen Cargada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar imagen: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarRegistro()
        {
            try
            {
                // Validar que hay una imagen para guardar
                if (imagen_PictureBox.Image == null)
                {
                    MessageBox.Show("No hay ninguna imagen para guardar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.udmImage_UploadsBindingSource.Current != null)
                {
                    DataRowView row = (DataRowView)this.udmImage_UploadsBindingSource.Current;

                    // Convertir imagen a bytes
                    byte[] imagenBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ImageFormat formato = imagen_PictureBox.Image.RawFormat;

                        // Guardar en el formato original, o como PNG por defecto
                        if (formato.Equals(ImageFormat.Gif))
                        {
                            imagen_PictureBox.Image.Save(ms, ImageFormat.Gif);
                        }
                        else if (formato.Equals(ImageFormat.Jpeg))
                        {
                            imagen_PictureBox.Image.Save(ms, ImageFormat.Jpeg);
                        }
                        else if (formato.Equals(ImageFormat.Png))
                        {
                            imagen_PictureBox.Image.Save(ms, ImageFormat.Png);
                        }
                        else
                        {
                            imagen_PictureBox.Image.Save(ms, ImageFormat.Png);
                        }

                        imagenBytes = ms.ToArray();
                    }

                    // Guardar la imagen (BLOB)
                    row["Imagen:"] = imagenBytes;

                    // Guardar la ruta
                    if (row.Row.Table.Columns.Contains("Ruta de Imagen:"))
                    {
                        row["Ruta de Imagen:"] = ruta_de_Imagen_Label1.Text;
                    }

                    // Guardar el nombre si el campo existe y no está lleno
                    if (row.Row.Table.Columns.Contains("Nombre:"))
                    {
                        if (row["Nombre:"] == DBNull.Value || string.IsNullOrEmpty(row["Nombre:"].ToString()))
                        {
                            string nombreArchivo = Path.GetFileNameWithoutExtension(ruta_de_Imagen_Label1.Text);
                            row["Nombre:"] = nombreArchivo;
                        }
                    }
                }

                // Finalizar edición y guardar en la base de datos
                this.Validate();
                this.udmImage_UploadsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.udmImages);

                MessageBox.Show("Datos guardados exitosamente en la base de datos!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}\n\nDetalles: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarImagen()
        {
            if (imagen_PictureBox.Image != null)
            {
                var temp = imagen_PictureBox.Image;
                imagen_PictureBox.Image = null;
                temp.Dispose();
            }
        }

        // Método para eliminar el registro actual de forma segura y directa
        private void EliminarRegistroActual()
        {
            try
            {
                if (this.udmImage_UploadsBindingSource.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (this.udmImage_UploadsBindingSource.Current == null)
                {
                    MessageBox.Show("No hay ningún registro seleccionado.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Detener animación y limpiar la imagen antes de eliminar
                if (imagen_PictureBox.Image != null)
                {
                    ImageAnimator.StopAnimate(imagen_PictureBox.Image, OnFrameChanged);
                }
                LimpiarImagen();

                DataRowView currentRow = (DataRowView)this.udmImage_UploadsBindingSource.Current;
                currentRow.Row.Delete();

                // Guardar cambios en la base de datos inmediatamente
                this.tableAdapterManager.UpdateAll(this.udmImages);

                // Refrescar el binding
                this.udmImage_UploadsBindingSource.ResetBindings(false);

                MessageBox.Show("Registro eliminado exitosamente.", "Eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón Eliminar del BindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            EliminarRegistroActual();
        }

        // Método alternativo por si el evento se llama diferente
        private void udmImage_UploadsBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            EliminarRegistroActual();
        }

        // Todos los botones de guardar llaman al mismo método
        private void udmImage_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            GuardarRegistro();
        }
    }
}