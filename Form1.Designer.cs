namespace UdemyPictureUploader
{
    partial class udemyPictureUploader
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_Label;
            System.Windows.Forms.Label nombre_Label;
            System.Windows.Forms.Label ruta_de_Imagen_Label;
            System.Windows.Forms.Label imagen_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(udemyPictureUploader));
            this.udmImages = new UdemyPictureUploader.udmImages();
            this.udmImage_UploadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udmImage_UploadsTableAdapter = new UdemyPictureUploader.udmImagesTableAdapters.udmImage_UploadsTableAdapter();
            this.tableAdapterManager = new UdemyPictureUploader.udmImagesTableAdapters.TableAdapterManager();
            this.udmImage_UploadsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.udmImage_UploadsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_Label1 = new System.Windows.Forms.Label();
            this.nombre_TextBox = new System.Windows.Forms.TextBox();
            this.ruta_de_Imagen_Label1 = new System.Windows.Forms.Label();
            this.imagen_PictureBox = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            iD_Label = new System.Windows.Forms.Label();
            nombre_Label = new System.Windows.Forms.Label();
            ruta_de_Imagen_Label = new System.Windows.Forms.Label();
            imagen_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udmImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udmImage_UploadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udmImage_UploadsBindingNavigator)).BeginInit();
            this.udmImage_UploadsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Label
            // 
            iD_Label.AutoSize = true;
            iD_Label.Location = new System.Drawing.Point(12, 35);
            iD_Label.Name = "iD_Label";
            iD_Label.Size = new System.Drawing.Size(21, 13);
            iD_Label.TabIndex = 1;
            iD_Label.Text = "ID:";
            // 
            // nombre_Label
            // 
            nombre_Label.AutoSize = true;
            nombre_Label.Location = new System.Drawing.Point(12, 64);
            nombre_Label.Name = "nombre_Label";
            nombre_Label.Size = new System.Drawing.Size(47, 13);
            nombre_Label.TabIndex = 3;
            nombre_Label.Text = "Nombre:";
            // 
            // ruta_de_Imagen_Label
            // 
            ruta_de_Imagen_Label.AutoSize = true;
            ruta_de_Imagen_Label.Location = new System.Drawing.Point(12, 84);
            ruta_de_Imagen_Label.Name = "ruta_de_Imagen_Label";
            ruta_de_Imagen_Label.Size = new System.Drawing.Size(86, 13);
            ruta_de_Imagen_Label.TabIndex = 5;
            ruta_de_Imagen_Label.Text = "Ruta de Imagen:";
            // 
            // imagen_Label
            // 
            imagen_Label.AutoSize = true;
            imagen_Label.Location = new System.Drawing.Point(12, 110);
            imagen_Label.Name = "imagen_Label";
            imagen_Label.Size = new System.Drawing.Size(45, 13);
            imagen_Label.TabIndex = 7;
            imagen_Label.Text = "Imagen:";
            // 
            // udmImages
            // 
            this.udmImages.DataSetName = "udmImages";
            this.udmImages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // udmImage_UploadsBindingSource
            // 
            this.udmImage_UploadsBindingSource.DataMember = "udmImage_Uploads";
            this.udmImage_UploadsBindingSource.DataSource = this.udmImages;
            // 
            // udmImage_UploadsTableAdapter
            // 
            this.udmImage_UploadsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.udmImage_UploadsTableAdapter = this.udmImage_UploadsTableAdapter;
            this.tableAdapterManager.UpdateOrder = UdemyPictureUploader.udmImagesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // udmImage_UploadsBindingNavigator
            // 
            this.udmImage_UploadsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.udmImage_UploadsBindingNavigator.BindingSource = this.udmImage_UploadsBindingSource;
            this.udmImage_UploadsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.udmImage_UploadsBindingNavigator.DeleteItem = null;
            this.udmImage_UploadsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.udmImage_UploadsBindingNavigatorSaveItem});
            this.udmImage_UploadsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.udmImage_UploadsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.udmImage_UploadsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.udmImage_UploadsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.udmImage_UploadsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.udmImage_UploadsBindingNavigator.Name = "udmImage_UploadsBindingNavigator";
            this.udmImage_UploadsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.udmImage_UploadsBindingNavigator.Size = new System.Drawing.Size(544, 25);
            this.udmImage_UploadsBindingNavigator.TabIndex = 0;
            this.udmImage_UploadsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // udmImage_UploadsBindingNavigatorSaveItem
            // 
            this.udmImage_UploadsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.udmImage_UploadsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("udmImage_UploadsBindingNavigatorSaveItem.Image")));
            this.udmImage_UploadsBindingNavigatorSaveItem.Name = "udmImage_UploadsBindingNavigatorSaveItem";
            this.udmImage_UploadsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.udmImage_UploadsBindingNavigatorSaveItem.Text = "Guardar datos";
            this.udmImage_UploadsBindingNavigatorSaveItem.Click += new System.EventHandler(this.udmImage_UploadsBindingNavigatorSaveItem_Click_4);
            // 
            // iD_Label1
            // 
            this.iD_Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.udmImage_UploadsBindingSource, "ID:", true));
            this.iD_Label1.Location = new System.Drawing.Point(104, 35);
            this.iD_Label1.Name = "iD_Label1";
            this.iD_Label1.Size = new System.Drawing.Size(423, 23);
            this.iD_Label1.TabIndex = 2;
            this.iD_Label1.Text = "                      ";
            // 
            // nombre_TextBox
            // 
            this.nombre_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.udmImage_UploadsBindingSource, "Nombre:", true));
            this.nombre_TextBox.Location = new System.Drawing.Point(104, 61);
            this.nombre_TextBox.Name = "nombre_TextBox";
            this.nombre_TextBox.Size = new System.Drawing.Size(423, 20);
            this.nombre_TextBox.TabIndex = 4;
            // 
            // ruta_de_Imagen_Label1
            // 
            this.ruta_de_Imagen_Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.udmImage_UploadsBindingSource, "Ruta de Imagen:", true));
            this.ruta_de_Imagen_Label1.Location = new System.Drawing.Point(104, 84);
            this.ruta_de_Imagen_Label1.Name = "ruta_de_Imagen_Label1";
            this.ruta_de_Imagen_Label1.Size = new System.Drawing.Size(423, 23);
            this.ruta_de_Imagen_Label1.TabIndex = 6;
            this.ruta_de_Imagen_Label1.Text = "                      ";
            // 
            // imagen_PictureBox
            // 
            this.imagen_PictureBox.Location = new System.Drawing.Point(104, 110);
            this.imagen_PictureBox.Name = "imagen_PictureBox";
            this.imagen_PictureBox.Size = new System.Drawing.Size(423, 328);
            this.imagen_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen_PictureBox.TabIndex = 8;
            this.imagen_PictureBox.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(15, 148);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // udemyPictureUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(iD_Label);
            this.Controls.Add(this.iD_Label1);
            this.Controls.Add(nombre_Label);
            this.Controls.Add(this.nombre_TextBox);
            this.Controls.Add(ruta_de_Imagen_Label);
            this.Controls.Add(this.ruta_de_Imagen_Label1);
            this.Controls.Add(imagen_Label);
            this.Controls.Add(this.imagen_PictureBox);
            this.Controls.Add(this.udmImage_UploadsBindingNavigator);
            this.Name = "udemyPictureUploader";
            this.Text = "Udemy Picture Uploader";
            this.Load += new System.EventHandler(this.udemyPictureUploader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udmImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udmImage_UploadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udmImage_UploadsBindingNavigator)).EndInit();
            this.udmImage_UploadsBindingNavigator.ResumeLayout(false);
            this.udmImage_UploadsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private udmImages udmImages;
        private System.Windows.Forms.BindingSource udmImage_UploadsBindingSource;
        private udmImagesTableAdapters.udmImage_UploadsTableAdapter udmImage_UploadsTableAdapter;
        private udmImagesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator udmImage_UploadsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton udmImage_UploadsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_Label1;
        private System.Windows.Forms.TextBox nombre_TextBox;
        private System.Windows.Forms.Label ruta_de_Imagen_Label1;
        private System.Windows.Forms.PictureBox imagen_PictureBox;
        private System.Windows.Forms.Button btnCargar;
    }
}

