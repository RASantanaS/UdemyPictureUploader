using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UdemyPictureUploader
{
    public partial class udemyPictureUploader : Form
    {
        public udemyPictureUploader()
        {
            InitializeComponent();
        }

        // Método unificado para guardar - todos los eventos duplicados llaman a este
        private void GuardarCambios()
        {
            try
            {
                this.Validate();
                this.udmImage_UploadsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.udmImages);
                MessageBox.Show("Datos guardados exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void udmImage_UploadsBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void udemyPictureUploader_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga los datos de la tabla udmImage_Uploads en el DataSet
                this.udmImage_UploadsTableAdapter.Fill(this.udmImages.udmImage_Uploads);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFd = new OpenFileDialog())
            {
                openFd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFd.Title = "Seleccionar Imagen";
                openFd.Multiselect = false;

                if (openFd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Verificar que el archivo existe
                        if (!File.Exists(openFd.FileName))
                        {
                            MessageBox.Show("El archivo seleccionado no existe.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Liberar la imagen anterior si existe para evitar bloqueo de archivos
                        if (imagen_PictureBox.Image != null)
                        {
                            imagen_PictureBox.Image.Dispose();
                        }

                        // Cargar la imagen desde un stream para no bloquear el archivo
                        using (var stream = new FileStream(openFd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            imagen_PictureBox.Image = Image.FromStream(stream);
                        }

                        // Mostrar la ruta de la imagen
                        ruta_de_Imagen_Label1.Text = openFd.FileName;
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}