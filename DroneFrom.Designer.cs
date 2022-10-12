namespace DroneServiceApplication
{
    partial class DroneFrom
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.mltxtProblem = new System.Windows.Forms.TextBox();
            this.lblProblems = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTag = new System.Windows.Forms.Label();
            this.grpbxRadioBtn = new System.Windows.Forms.GroupBox();
            this.rdoExpress = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lstViewRegular = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewExpress = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRegularFinish = new System.Windows.Forms.Button();
            this.btnExpressFinish = new System.Windows.Forms.Button();
            this.lstBoxFinished = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpbxRadioBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Client Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(198, 19);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(71, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Drone Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(267, 16);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(618, 18);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(70, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Service Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(688, 16);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 5;
            // 
            // mltxtProblem
            // 
            this.mltxtProblem.Location = new System.Drawing.Point(463, 16);
            this.mltxtProblem.Multiline = true;
            this.mltxtProblem.Name = "mltxtProblem";
            this.mltxtProblem.Size = new System.Drawing.Size(135, 59);
            this.mltxtProblem.TabIndex = 6;
            // 
            // lblProblems
            // 
            this.lblProblems.AutoSize = true;
            this.lblProblems.Location = new System.Drawing.Point(370, 18);
            this.lblProblems.Name = "lblProblems";
            this.lblProblems.Size = new System.Drawing.Size(92, 13);
            this.lblProblems.TabIndex = 7;
            this.lblProblems.Text = "Service Problems:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(877, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(808, 19);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(68, 13);
            this.lblTag.TabIndex = 9;
            this.lblTag.Text = "Service Tag:";
            // 
            // grpbxRadioBtn
            // 
            this.grpbxRadioBtn.Controls.Add(this.rdoExpress);
            this.grpbxRadioBtn.Controls.Add(this.rdoRegular);
            this.grpbxRadioBtn.Location = new System.Drawing.Point(15, 61);
            this.grpbxRadioBtn.Name = "grpbxRadioBtn";
            this.grpbxRadioBtn.Size = new System.Drawing.Size(123, 67);
            this.grpbxRadioBtn.TabIndex = 10;
            this.grpbxRadioBtn.TabStop = false;
            this.grpbxRadioBtn.Text = "Select Service Type:";
            // 
            // rdoExpress
            // 
            this.rdoExpress.AutoSize = true;
            this.rdoExpress.Location = new System.Drawing.Point(6, 42);
            this.rdoExpress.Name = "rdoExpress";
            this.rdoExpress.Size = new System.Drawing.Size(62, 17);
            this.rdoExpress.TabIndex = 1;
            this.rdoExpress.TabStop = true;
            this.rdoExpress.Text = "Express";
            this.rdoExpress.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(6, 19);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(62, 17);
            this.rdoRegular.TabIndex = 0;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lstViewRegular
            // 
            this.lstViewRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnModel,
            this.clmnProblem,
            this.clmnCost,
            this.clmnTag});
            this.lstViewRegular.HideSelection = false;
            this.lstViewRegular.Location = new System.Drawing.Point(70, 159);
            this.lstViewRegular.Name = "lstViewRegular";
            this.lstViewRegular.Size = new System.Drawing.Size(392, 219);
            this.lstViewRegular.TabIndex = 12;
            this.lstViewRegular.UseCompatibleStateImageBehavior = false;
            this.lstViewRegular.View = System.Windows.Forms.View.Details;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Client Name";
            this.clmnName.Width = 70;
            // 
            // clmnModel
            // 
            this.clmnModel.Text = "Drone Model";
            this.clmnModel.Width = 74;
            // 
            // clmnProblem
            // 
            this.clmnProblem.Text = "Service Problems";
            this.clmnProblem.Width = 95;
            // 
            // clmnCost
            // 
            this.clmnCost.Text = "Service Cost";
            this.clmnCost.Width = 72;
            // 
            // clmnTag
            // 
            this.clmnTag.Text = "Service Tag";
            this.clmnTag.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Regular Service";
            // 
            // lstViewExpress
            // 
            this.lstViewExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewExpress.HideSelection = false;
            this.lstViewExpress.Location = new System.Drawing.Point(606, 159);
            this.lstViewExpress.Name = "lstViewExpress";
            this.lstViewExpress.Size = new System.Drawing.Size(391, 219);
            this.lstViewExpress.TabIndex = 14;
            this.lstViewExpress.UseCompatibleStateImageBehavior = false;
            this.lstViewExpress.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client Name";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Drone Model";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Service Problem";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Service Cost";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Service Tag";
            this.columnHeader5.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Express Service";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1003, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRegularFinish
            // 
            this.btnRegularFinish.Location = new System.Drawing.Point(217, 384);
            this.btnRegularFinish.Name = "btnRegularFinish";
            this.btnRegularFinish.Size = new System.Drawing.Size(100, 23);
            this.btnRegularFinish.TabIndex = 17;
            this.btnRegularFinish.Text = "Complete Service";
            this.btnRegularFinish.UseVisualStyleBackColor = true;
            // 
            // btnExpressFinish
            // 
            this.btnExpressFinish.Location = new System.Drawing.Point(759, 385);
            this.btnExpressFinish.Name = "btnExpressFinish";
            this.btnExpressFinish.Size = new System.Drawing.Size(104, 23);
            this.btnExpressFinish.TabIndex = 18;
            this.btnExpressFinish.Text = "Complete Service";
            this.btnExpressFinish.UseVisualStyleBackColor = true;
            // 
            // lstBoxFinished
            // 
            this.lstBoxFinished.FormattingEnabled = true;
            this.lstBoxFinished.Location = new System.Drawing.Point(413, 436);
            this.lstBoxFinished.Name = "lstBoxFinished";
            this.lstBoxFinished.Size = new System.Drawing.Size(297, 134);
            this.lstBoxFinished.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Completed Drone Services";
            // 
            // DroneFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBoxFinished);
            this.Controls.Add(this.btnExpressFinish);
            this.Controls.Add(this.btnRegularFinish);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstViewExpress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViewRegular);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpbxRadioBtn);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblProblems);
            this.Controls.Add(this.mltxtProblem);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "DroneFrom";
            this.Text = "Drone Service Application";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpbxRadioBtn.ResumeLayout(false);
            this.grpbxRadioBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox mltxtProblem;
        private System.Windows.Forms.Label lblProblems;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.GroupBox grpbxRadioBtn;
        private System.Windows.Forms.RadioButton rdoExpress;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lstViewRegular;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnModel;
        private System.Windows.Forms.ColumnHeader clmnProblem;
        private System.Windows.Forms.ColumnHeader clmnCost;
        private System.Windows.Forms.ColumnHeader clmnTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewExpress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRegularFinish;
        private System.Windows.Forms.Button btnExpressFinish;
        private System.Windows.Forms.ListBox lstBoxFinished;
        private System.Windows.Forms.Label label3;
    }
}

