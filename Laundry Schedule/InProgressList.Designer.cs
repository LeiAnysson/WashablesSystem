﻿namespace WashablesSystem
{
    partial class InProgressList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ScheduleTime = new System.Windows.Forms.Label();
            this.PickUpDate = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.UnitUsed = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.Label();
            this.Weights = new System.Windows.Forms.Label();
            this.ORNo = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________________";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 2F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(912, 98);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(14, 4);
            this.lblStatus.TabIndex = 96;
            this.lblStatus.Text = "Playing";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // ScheduleTime
            // 
            this.ScheduleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleTime.AutoSize = true;
            this.ScheduleTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTime.Location = new System.Drawing.Point(487, 38);
            this.ScheduleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleTime.Name = "ScheduleTime";
            this.ScheduleTime.Size = new System.Drawing.Size(103, 17);
            this.ScheduleTime.TabIndex = 81;
            this.ScheduleTime.Text = "Scheduled Time";
            this.ScheduleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PickUpDate
            // 
            this.PickUpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PickUpDate.AutoSize = true;
            this.PickUpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpDate.Location = new System.Drawing.Point(717, 38);
            this.PickUpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.Size = new System.Drawing.Size(80, 17);
            this.PickUpDate.TabIndex = 83;
            this.PickUpDate.Text = "Pickup Date";
            this.PickUpDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.Location = new System.Drawing.Point(820, 30);
            this.TimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(37, 34);
            this.TimeLeft.TabIndex = 84;
            this.TimeLeft.Text = "Time Left";
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.Image = global::WashablesSystem.Properties.Resources.Pause;
            this.btnPause.Location = new System.Drawing.Point(866, 33);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(28, 27);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 85;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // UnitUsed
            // 
            this.UnitUsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitUsed.AutoSize = true;
            this.UnitUsed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitUsed.Location = new System.Drawing.Point(195, 30);
            this.UnitUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnitUsed.Name = "UnitUsed";
            this.UnitUsed.Size = new System.Drawing.Size(38, 34);
            this.UnitUsed.TabIndex = 78;
            this.UnitUsed.Text = "Unit Used";
            this.UnitUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Services
            // 
            this.Services.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Services.AutoSize = true;
            this.Services.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(282, 38);
            this.Services.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(57, 17);
            this.Services.TabIndex = 79;
            this.Services.Text = "Services";
            this.Services.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weights
            // 
            this.Weights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weights.AutoSize = true;
            this.Weights.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weights.Location = new System.Drawing.Point(390, 30);
            this.Weights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weights.Name = "Weights";
            this.Weights.Size = new System.Drawing.Size(52, 34);
            this.Weights.TabIndex = 82;
            this.Weights.Text = "Weight (kg)";
            this.Weights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ORNo
            // 
            this.ORNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ORNo.AutoSize = true;
            this.ORNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORNo.Location = new System.Drawing.Point(2, 38);
            this.ORNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ORNo.Name = "ORNo";
            this.ORNo.Size = new System.Drawing.Size(29, 17);
            this.ORNo.TabIndex = 77;
            this.ORNo.Text = "No.";
            this.ORNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(58, 38);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(107, 17);
            this.CustomerName.TabIndex = 80;
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.UnitUsed, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPause, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimeLeft, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.PickUpDate, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.ScheduleTime, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.CustomerName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ORNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Weights, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Services, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 10, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-4, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(924, 94);
            this.tableLayoutPanel2.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 34);
            this.label2.TabIndex = 87;
            this.label2.Text = "Actual Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Image = global::WashablesSystem.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(896, 34);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 86;
            this.btnCancel.TabStop = false;
            // 
            // InProgressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InProgressList";
            this.Size = new System.Drawing.Size(920, 103);
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label ScheduleTime;
        private System.Windows.Forms.Label PickUpDate;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label UnitUsed;
        private System.Windows.Forms.Label Services;
        private System.Windows.Forms.Label Weights;
        private System.Windows.Forms.Label ORNo;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}