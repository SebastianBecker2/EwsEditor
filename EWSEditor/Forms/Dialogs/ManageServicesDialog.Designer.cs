namespace EWSEditor.Forms
{
    partial class ManageServicesDialog
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
            this.lsbStoredServices = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.lblServiceCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditService = new System.Windows.Forms.Button();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbStoredServices
            // 
            this.lsbStoredServices.FormattingEnabled = true;
            this.lsbStoredServices.Location = new System.Drawing.Point(12, 12);
            this.lsbStoredServices.Name = "lsbStoredServices";
            this.lsbStoredServices.Size = new System.Drawing.Size(120, 147);
            this.lsbStoredServices.TabIndex = 0;
            this.lsbStoredServices.SelectedIndexChanged += new System.EventHandler(this.lsbStoredServices_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(211, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            this.btnAddService.Enabled = false;
            this.btnAddService.Location = new System.Drawing.Point(138, 59);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(148, 23);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Add Exchange Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Enabled = false;
            this.btnRemoveService.Location = new System.Drawing.Point(138, 136);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(148, 23);
            this.btnRemoveService.TabIndex = 3;
            this.btnRemoveService.Text = "Remove Exchange Service";
            this.btnRemoveService.UseVisualStyleBackColor = true;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // lblServiceCount
            // 
            this.lblServiceCount.AutoSize = true;
            this.lblServiceCount.Location = new System.Drawing.Point(108, 162);
            this.lblServiceCount.Name = "lblServiceCount";
            this.lblServiceCount.Size = new System.Drawing.Size(24, 13);
            this.lblServiceCount.TabIndex = 4;
            this.lblServiceCount.Text = "0/5";
            this.lblServiceCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stored Services:";
            // 
            // btnEditService
            // 
            this.btnEditService.Enabled = false;
            this.btnEditService.Location = new System.Drawing.Point(138, 107);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(148, 23);
            this.btnEditService.TabIndex = 6;
            this.btnEditService.Text = "Edit Exchange Service";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(138, 33);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(147, 20);
            this.txtServiceName.TabIndex = 7;
            this.txtServiceName.TextChanged += new System.EventHandler(this.txtServiceName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Service Name:";
            // 
            // ManageServicesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(298, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServiceCount);
            this.Controls.Add(this.btnRemoveService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lsbStoredServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageServicesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EWS Editor - Manage Stored Exchange Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbStoredServices;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Label lblServiceCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label2;
    }
}