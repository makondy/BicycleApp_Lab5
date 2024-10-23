namespace BicycleApp_Lab5
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.gvBicycles = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.bindSrcBicycles = new System.Windows.Forms.BindingSource(this.components);
            this.bicycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvBicycles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcBicycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBicycles
            // 
            this.gvBicycles.AllowUserToAddRows = false;
            this.gvBicycles.AllowUserToDeleteRows = false;
            this.gvBicycles.AutoGenerateColumns = false;
            this.gvBicycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBicycles.DataSource = this.bindSrcBicycles;
            this.gvBicycles.Location = new System.Drawing.Point(0, 28);
            this.gvBicycles.Name = "gvBicycles";
            this.gvBicycles.ReadOnly = true;
            this.gvBicycles.Size = new System.Drawing.Size(943, 409);
            this.gvBicycles.TabIndex = 5;
            this.gvBicycles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBicycles_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Додати запис про велосипед";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "Очистити дані";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel,
            this.btnClear,
            this.btnSaveAsText,
            this.btnSaveAsBinary,
            this.btnOpenFromText,
            this.btnOpenFromBinary,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.bindSrcBicycles_CurrentChanged);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = global::BicycleApp_Lab5.Properties.Resources.photo_2024_10_20_14_10_53;
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFromText.Text = "Читання даних із текстового файлу";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromBinary.Image")));
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFromBinary.Text = "Читання даних із бінарного файлу";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAsBinary.Text = "Збереження даних у бінарний файл";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAsText.Text = "Збереження даних у текстовий файл";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // bindSrcBicycles
            // 
            this.bindSrcBicycles.CurrentChanged += new System.EventHandler(this.bindSrcBicycles_CurrentChanged);
            // 
            // bicycleBindingSource
            // 
            this.bicycleBindingSource.DataSource = typeof(BicycleApp_Lab5.Bicycle);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 449);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvBicycles);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №5";
            ((System.ComponentModel.ISupportInitialize)(this.gvBicycles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcBicycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvBicycles;
        private System.Windows.Forms.BindingSource bicycleBindingSource;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindSrcBicycles;
        private System.Windows.Forms.ToolStripButton btnOpenFromText;
        private System.Windows.Forms.ToolStripButton btnOpenFromBinary;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
    }
}

