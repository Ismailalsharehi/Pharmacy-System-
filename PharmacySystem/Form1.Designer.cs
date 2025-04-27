namespace PharmacySystem
{
    partial class Form1
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
            System.Windows.Forms.TableLayoutPanel DataTable;
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.item1Name = new System.Windows.Forms.Label();
            DataTable = new System.Windows.Forms.TableLayoutPanel();
            DataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            DataTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            DataTable.AutoScroll = true;
            DataTable.AutoScrollMargin = new System.Drawing.Size(1, 1);
            DataTable.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            DataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            DataTable.ColumnCount = 6;
            DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.37736F));
            DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.62264F));
            DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 477F));
            DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            DataTable.Controls.Add(this.label6, 5, 0);
            DataTable.Controls.Add(this.label5, 4, 0);
            DataTable.Controls.Add(this.label4, 3, 0);
            DataTable.Controls.Add(this.label3, 2, 0);
            DataTable.Controls.Add(this.label2, 1, 0);
            DataTable.Controls.Add(this.medicineImage, 1, 1);
            DataTable.Controls.Add(this.panel1, 2, 1);
            DataTable.Controls.Add(this.label1, 0, 0);
            DataTable.Controls.Add(this.item1Name, 0, 1);
            DataTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            DataTable.ForeColor = System.Drawing.SystemColors.ControlText;
            DataTable.Location = new System.Drawing.Point(5, 116);
            DataTable.Name = "DataTable";
            DataTable.RowCount = 8;
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.64706F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.35294F));
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            DataTable.Size = new System.Drawing.Size(1097, 222);
            DataTable.TabIndex = 0;
            DataTable.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "الحالة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(92, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "تاريخ الشراء";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(257, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "اجمالي السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(355, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "المشتريات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(835, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "صورة الوثيقة الطبية";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicineImage
            // 
            this.medicineImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineImage.Location = new System.Drawing.Point(835, 55);
            this.medicineImage.Name = "medicineImage";
            this.medicineImage.Size = new System.Drawing.Size(97, 23);
            this.medicineImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicineImage.TabIndex = 1;
            this.medicineImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(355, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 23);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(941, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // item1Name
            // 
            this.item1Name.AutoSize = true;
            this.item1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item1Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.item1Name.Location = new System.Drawing.Point(941, 52);
            this.item1Name.Name = "item1Name";
            this.item1Name.Size = new System.Drawing.Size(150, 29);
            this.item1Name.TabIndex = 9;
            this.item1Name.Text = "محمد احمد سعيد علي";
            this.item1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 613);
            this.Controls.Add(DataTable);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Sales";
            DataTable.ResumeLayout(false);
            DataTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox medicineImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label item1Name;
    }
}