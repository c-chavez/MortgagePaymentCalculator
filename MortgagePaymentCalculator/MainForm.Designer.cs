namespace MortgagePaymentCalculator
{
    partial class MainForm
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
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPageTerms = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBoxTerms = new System.Windows.Forms.GroupBox();
            this.numUpDwnDownPayment = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numUpDwnPaymentsPerYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDwnAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDwnRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDwnLoanTerm = new System.Windows.Forms.NumericUpDown();
            this.tabPageAmort = new System.Windows.Forms.TabPage();
            this.dgvAmortization = new System.Windows.Forms.DataGridView();
            this.tabCtrlMain.SuspendLayout();
            this.tabPageTerms.SuspendLayout();
            this.groupBoxTerms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnDownPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnPaymentsPerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLoanTerm)).BeginInit();
            this.tabPageAmort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortization)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPageTerms);
            this.tabCtrlMain.Controls.Add(this.tabPageAmort);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(675, 471);
            this.tabCtrlMain.TabIndex = 0;
            this.tabCtrlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlMain_Selected);
            // 
            // tabPageTerms
            // 
            this.tabPageTerms.Controls.Add(this.btnCalculate);
            this.tabPageTerms.Controls.Add(this.groupBoxTerms);
            this.tabPageTerms.Location = new System.Drawing.Point(4, 22);
            this.tabPageTerms.Name = "tabPageTerms";
            this.tabPageTerms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTerms.Size = new System.Drawing.Size(667, 445);
            this.tabPageTerms.TabIndex = 0;
            this.tabPageTerms.Text = "Terms";
            this.tabPageTerms.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(281, 27);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBoxTerms
            // 
            this.groupBoxTerms.Controls.Add(this.numUpDwnDownPayment);
            this.groupBoxTerms.Controls.Add(this.label5);
            this.groupBoxTerms.Controls.Add(this.numUpDwnPaymentsPerYear);
            this.groupBoxTerms.Controls.Add(this.label4);
            this.groupBoxTerms.Controls.Add(this.numUpDwnAmount);
            this.groupBoxTerms.Controls.Add(this.label3);
            this.groupBoxTerms.Controls.Add(this.label1);
            this.groupBoxTerms.Controls.Add(this.numUpDwnRate);
            this.groupBoxTerms.Controls.Add(this.label2);
            this.groupBoxTerms.Controls.Add(this.numUpDwnLoanTerm);
            this.groupBoxTerms.Location = new System.Drawing.Point(8, 18);
            this.groupBoxTerms.Name = "groupBoxTerms";
            this.groupBoxTerms.Size = new System.Drawing.Size(267, 151);
            this.groupBoxTerms.TabIndex = 5;
            this.groupBoxTerms.TabStop = false;
            this.groupBoxTerms.Text = "Loan Terms";
            // 
            // numUpDwnDownPayment
            // 
            this.numUpDwnDownPayment.Location = new System.Drawing.Point(117, 118);
            this.numUpDwnDownPayment.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numUpDwnDownPayment.Name = "numUpDwnDownPayment";
            this.numUpDwnDownPayment.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnDownPayment.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Down Payment";
            // 
            // numUpDwnPaymentsPerYear
            // 
            this.numUpDwnPaymentsPerYear.Location = new System.Drawing.Point(117, 92);
            this.numUpDwnPaymentsPerYear.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numUpDwnPaymentsPerYear.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDwnPaymentsPerYear.Name = "numUpDwnPaymentsPerYear";
            this.numUpDwnPaymentsPerYear.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnPaymentsPerYear.TabIndex = 8;
            this.numUpDwnPaymentsPerYear.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payments Per Year";
            // 
            // numUpDwnAmount
            // 
            this.numUpDwnAmount.Location = new System.Drawing.Point(117, 12);
            this.numUpDwnAmount.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numUpDwnAmount.Name = "numUpDwnAmount";
            this.numUpDwnAmount.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnAmount.TabIndex = 6;
            this.numUpDwnAmount.Value = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loan Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Term";
            // 
            // numUpDwnRate
            // 
            this.numUpDwnRate.Location = new System.Drawing.Point(117, 66);
            this.numUpDwnRate.Name = "numUpDwnRate";
            this.numUpDwnRate.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnRate.TabIndex = 4;
            this.numUpDwnRate.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate";
            // 
            // numUpDwnLoanTerm
            // 
            this.numUpDwnLoanTerm.Location = new System.Drawing.Point(117, 38);
            this.numUpDwnLoanTerm.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDwnLoanTerm.Name = "numUpDwnLoanTerm";
            this.numUpDwnLoanTerm.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnLoanTerm.TabIndex = 3;
            this.numUpDwnLoanTerm.UseWaitCursor = true;
            this.numUpDwnLoanTerm.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // tabPageAmort
            // 
            this.tabPageAmort.Controls.Add(this.dgvAmortization);
            this.tabPageAmort.Location = new System.Drawing.Point(4, 22);
            this.tabPageAmort.Name = "tabPageAmort";
            this.tabPageAmort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAmort.Size = new System.Drawing.Size(667, 445);
            this.tabPageAmort.TabIndex = 1;
            this.tabPageAmort.Text = "Amortization";
            this.tabPageAmort.UseVisualStyleBackColor = true;
            // 
            // dgvAmortization
            // 
            this.dgvAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmortization.Location = new System.Drawing.Point(8, 24);
            this.dgvAmortization.Name = "dgvAmortization";
            this.dgvAmortization.Size = new System.Drawing.Size(651, 398);
            this.dgvAmortization.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 471);
            this.Controls.Add(this.tabCtrlMain);
            this.Name = "MainForm";
            this.Text = "Mortgage Calculator";
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPageTerms.ResumeLayout(false);
            this.groupBoxTerms.ResumeLayout(false);
            this.groupBoxTerms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnDownPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnPaymentsPerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLoanTerm)).EndInit();
            this.tabPageAmort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmortization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabPageTerms;
        private System.Windows.Forms.TabPage tabPageAmort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDwnRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDwnLoanTerm;
        private System.Windows.Forms.GroupBox groupBoxTerms;
        private System.Windows.Forms.NumericUpDown numUpDwnAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDwnPaymentsPerYear;
        private System.Windows.Forms.NumericUpDown numUpDwnDownPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAmortization;
    }
}

