using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class CRListDisplay
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Todate = new System.Windows.Forms.Label();
            this.Fromdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TopPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.82076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.17924F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.Controls.Add(this.SubmitBtn);
            this.TopPanel.Controls.Add(this.dateTimePicker2);
            this.TopPanel.Controls.Add(this.dateTimePicker1);
            this.TopPanel.Controls.Add(this.Fromdate);
            this.TopPanel.Controls.Add(this.Todate);
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(960, 115);
            this.TopPanel.TabIndex = 1;
            // 
            // Todate
            // 
            this.Todate.AutoSize = true;
            this.Todate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todate.Location = new System.Drawing.Point(84, 80);
            this.Todate.Name = "Todate";
            this.Todate.Size = new System.Drawing.Size(52, 15);
            this.Todate.TabIndex = 0;
            this.Todate.Text = "To Date:";
            // 
            // Fromdate
            // 
            this.Fromdate.AutoSize = true;
            this.Fromdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fromdate.Location = new System.Drawing.Point(84, 43);
            this.Fromdate.Name = "Fromdate";
            this.Fromdate.Size = new System.Drawing.Size(65, 15);
            this.Fromdate.TabIndex = 1;
            this.Fromdate.Text = "From Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(167, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(401, 56);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // CRListDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CRListDisplay";
            this.Text = "CRListDisplay";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Panel TopPanel;
        private Button SubmitBtn;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label Fromdate;
        private Label Todate;
    }
}