
namespace Simple_Macro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblKeyToMacro = new System.Windows.Forms.Label();
			this.cmbCurrentKey = new System.Windows.Forms.ComboBox();
			this.btnStartMacro = new System.Windows.Forms.Button();
			this.btnStopMacro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblKeyToMacro
			// 
			this.lblKeyToMacro.AutoSize = true;
			this.lblKeyToMacro.Location = new System.Drawing.Point(12, 14);
			this.lblKeyToMacro.Name = "lblKeyToMacro";
			this.lblKeyToMacro.Size = new System.Drawing.Size(36, 19);
			this.lblKeyToMacro.TabIndex = 0;
			this.lblKeyToMacro.Text = "Key:";
			// 
			// cmbCurrentKey
			// 
			this.cmbCurrentKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbCurrentKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCurrentKey.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
			this.cmbCurrentKey.FormattingEnabled = true;
			this.cmbCurrentKey.Location = new System.Drawing.Point(54, 11);
			this.cmbCurrentKey.Name = "cmbCurrentKey";
			this.cmbCurrentKey.Size = new System.Drawing.Size(259, 24);
			this.cmbCurrentKey.TabIndex = 1;
			// 
			// btnStartMacro
			// 
			this.btnStartMacro.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnStartMacro.Location = new System.Drawing.Point(12, 41);
			this.btnStartMacro.Name = "btnStartMacro";
			this.btnStartMacro.Size = new System.Drawing.Size(301, 34);
			this.btnStartMacro.TabIndex = 2;
			this.btnStartMacro.Text = "Start Macro";
			this.btnStartMacro.UseVisualStyleBackColor = true;
			this.btnStartMacro.Click += new System.EventHandler(this.StartMacro);
			// 
			// btnStopMacro
			// 
			this.btnStopMacro.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnStopMacro.Location = new System.Drawing.Point(12, 41);
			this.btnStopMacro.Name = "btnStopMacro";
			this.btnStopMacro.Size = new System.Drawing.Size(301, 34);
			this.btnStopMacro.TabIndex = 3;
			this.btnStopMacro.Text = "Stop Macro";
			this.btnStopMacro.UseVisualStyleBackColor = true;
			this.btnStopMacro.Visible = false;
			this.btnStopMacro.Click += new System.EventHandler(this.StopMacro);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(325, 85);
			this.Controls.Add(this.btnStartMacro);
			this.Controls.Add(this.btnStopMacro);
			this.Controls.Add(this.cmbCurrentKey);
			this.Controls.Add(this.lblKeyToMacro);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simple Macro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblKeyToMacro;
		private System.Windows.Forms.ComboBox cmbCurrentKey;
		private System.Windows.Forms.Button btnStartMacro;
		private System.Windows.Forms.Button btnStopMacro;
	}
}

