namespace RS232
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxRead = new System.Windows.Forms.GroupBox();
            this.groupBoxWrite = new System.Windows.Forms.GroupBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolButtonSend = new System.Windows.Forms.ToolStripButton();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.toolComboBoxPortName = new System.Windows.Forms.ToolStripComboBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxRead.SuspendLayout();
            this.groupBoxWrite.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxRead, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxWrite, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(599, 419);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxRead
            // 
            this.groupBoxRead.Controls.Add(this.textBoxRead);
            this.groupBoxRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRead.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRead.Name = "groupBoxRead";
            this.groupBoxRead.Size = new System.Drawing.Size(593, 153);
            this.groupBoxRead.TabIndex = 0;
            this.groupBoxRead.TabStop = false;
            this.groupBoxRead.Text = "Odczyt";
            // 
            // groupBoxWrite
            // 
            this.groupBoxWrite.Controls.Add(this.textBoxWrite);
            this.groupBoxWrite.Controls.Add(this.toolStrip);
            this.groupBoxWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWrite.Location = new System.Drawing.Point(3, 162);
            this.groupBoxWrite.Name = "groupBoxWrite";
            this.groupBoxWrite.Size = new System.Drawing.Size(593, 153);
            this.groupBoxWrite.TabIndex = 1;
            this.groupBoxWrite.TabStop = false;
            this.groupBoxWrite.Text = "Zapis";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonSend,
            this.toolComboBoxPortName});
            this.toolStrip.Location = new System.Drawing.Point(3, 125);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(587, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolButtonSend
            // 
            this.toolButtonSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonSend.Image")));
            this.toolButtonSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonSend.Name = "toolButtonSend";
            this.toolButtonSend.Size = new System.Drawing.Size(42, 22);
            this.toolButtonSend.Text = "Wyślij";
            this.toolButtonSend.Click += new System.EventHandler(this.toolButtonSend_Click);
            // 
            // textBoxRead
            // 
            this.textBoxRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRead.Location = new System.Drawing.Point(3, 16);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.ReadOnly = true;
            this.textBoxRead.Size = new System.Drawing.Size(587, 134);
            this.textBoxRead.TabIndex = 0;
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWrite.Location = new System.Drawing.Point(3, 16);
            this.textBoxWrite.Multiline = true;
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(587, 109);
            this.textBoxWrite.TabIndex = 1;
            // 
            // toolComboBoxPortName
            // 
            this.toolComboBoxPortName.Name = "toolComboBoxPortName";
            this.toolComboBoxPortName.Size = new System.Drawing.Size(121, 25);
            this.toolComboBoxPortName.SelectedIndexChanged += new System.EventHandler(this.toolComboBoxPortName_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 419);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form";
            this.Text = "Form1";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxRead.ResumeLayout(false);
            this.groupBoxRead.PerformLayout();
            this.groupBoxWrite.ResumeLayout(false);
            this.groupBoxWrite.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxRead;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.GroupBox groupBoxWrite;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolButtonSend;
        private System.Windows.Forms.ToolStripComboBox toolComboBoxPortName;
    }
}

