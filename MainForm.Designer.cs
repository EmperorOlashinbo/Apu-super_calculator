namespace A3
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
            this.grpWaterIntake = new System.Windows.Forms.GroupBox();
            this.grpRecommendedWater = new System.Windows.Forms.GroupBox();
            this.lblWaterIntakeGlasses = new System.Windows.Forms.Label();
            this.lblDailyWaterIntake = new System.Windows.Forms.Label();
            this.lblWaterIntakeOunces = new System.Windows.Forms.Label();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rdoImperial = new System.Windows.Forms.RadioButton();
            this.rdoMetric = new System.Windows.Forms.RadioButton();
            this.btnCalculateWaterIntake = new System.Windows.Forms.Button();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeightIn = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtHeightFt = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.grpOtherData = new System.Windows.Forms.GroupBox();
            this.cmbActivityLevel = new System.Windows.Forms.ComboBox();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblActivityLevel = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.grpRetirement = new System.Windows.Forms.GroupBox();
            this.btnCalculateRetirement = new System.Windows.Forms.Button();
            this.grpFutureValues = new System.Windows.Forms.GroupBox();
            this.lblGrowthPercentage = new System.Windows.Forms.Label();
            this.lblTotalInvestment = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalFutureAmount = new System.Windows.Forms.Label();
            this.lblYearsToRetirement = new System.Windows.Forms.Label();
            this.lblGrowthPercentageText = new System.Windows.Forms.Label();
            this.lblTotalInvestmentText = new System.Windows.Forms.Label();
            this.lblTotalInterestText = new System.Windows.Forms.Label();
            this.lblTotalFutureAmountText = new System.Windows.Forms.Label();
            this.lblYearsToRetirementText = new System.Windows.Forms.Label();
            this.grpInvestment = new System.Windows.Forms.GroupBox();
            this.txtAnnualInterest = new System.Windows.Forms.TextBox();
            this.txtMonthlySavings = new System.Windows.Forms.TextBox();
            this.lblAnnualInterest = new System.Windows.Forms.Label();
            this.txtCurrentSavings = new System.Windows.Forms.TextBox();
            this.lblMonthlySavings = new System.Windows.Forms.Label();
            this.lblCurrentSavings = new System.Windows.Forms.Label();
            this.grpRetirementData = new System.Windows.Forms.GroupBox();
            this.cmbRetiringAge = new System.Windows.Forms.ComboBox();
            this.lblRetiringAge = new System.Windows.Forms.Label();
            this.grpWaterIntake.SuspendLayout();
            this.grpRecommendedWater.SuspendLayout();
            this.grpUnit.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.grpOtherData.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpRetirement.SuspendLayout();
            this.grpFutureValues.SuspendLayout();
            this.grpInvestment.SuspendLayout();
            this.grpRetirementData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWaterIntake
            // 
            this.grpWaterIntake.Controls.Add(this.grpRecommendedWater);
            this.grpWaterIntake.Controls.Add(this.grpUnit);
            this.grpWaterIntake.Controls.Add(this.btnCalculateWaterIntake);
            this.grpWaterIntake.Controls.Add(this.grpPersonalInfo);
            this.grpWaterIntake.Location = new System.Drawing.Point(12, 32);
            this.grpWaterIntake.Name = "grpWaterIntake";
            this.grpWaterIntake.Size = new System.Drawing.Size(1179, 453);
            this.grpWaterIntake.TabIndex = 0;
            this.grpWaterIntake.TabStop = false;
            this.grpWaterIntake.Text = "Daily Water Intake";
            // 
            // grpRecommendedWater
            // 
            this.grpRecommendedWater.Controls.Add(this.lblWaterIntakeGlasses);
            this.grpRecommendedWater.Controls.Add(this.lblDailyWaterIntake);
            this.grpRecommendedWater.Controls.Add(this.lblWaterIntakeOunces);
            this.grpRecommendedWater.Location = new System.Drawing.Point(17, 354);
            this.grpRecommendedWater.Name = "grpRecommendedWater";
            this.grpRecommendedWater.Size = new System.Drawing.Size(1069, 79);
            this.grpRecommendedWater.TabIndex = 1;
            this.grpRecommendedWater.TabStop = false;
            this.grpRecommendedWater.Text = "Recommended Daily Water Consumption for";
            this.grpRecommendedWater.Enter += new System.EventHandler(this.grpRecommendedWater_Enter);
            // 
            // lblWaterIntakeGlasses
            // 
            this.lblWaterIntakeGlasses.AutoSize = true;
            this.lblWaterIntakeGlasses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterIntakeGlasses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWaterIntakeGlasses.Location = new System.Drawing.Point(707, 41);
            this.lblWaterIntakeGlasses.Name = "lblWaterIntakeGlasses";
            this.lblWaterIntakeGlasses.Size = new System.Drawing.Size(0, 25);
            this.lblWaterIntakeGlasses.TabIndex = 3;
            this.lblWaterIntakeGlasses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDailyWaterIntake
            // 
            this.lblDailyWaterIntake.AutoSize = true;
            this.lblDailyWaterIntake.Location = new System.Drawing.Point(15, 41);
            this.lblDailyWaterIntake.Name = "lblDailyWaterIntake";
            this.lblDailyWaterIntake.Size = new System.Drawing.Size(151, 25);
            this.lblDailyWaterIntake.TabIndex = 1;
            this.lblDailyWaterIntake.Text = "Daily Water Intake";
            // 
            // lblWaterIntakeOunces
            // 
            this.lblWaterIntakeOunces.AutoSize = true;
            this.lblWaterIntakeOunces.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterIntakeOunces.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWaterIntakeOunces.Location = new System.Drawing.Point(284, 41);
            this.lblWaterIntakeOunces.Name = "lblWaterIntakeOunces";
            this.lblWaterIntakeOunces.Size = new System.Drawing.Size(0, 25);
            this.lblWaterIntakeOunces.TabIndex = 2;
            this.lblWaterIntakeOunces.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rdoImperial);
            this.grpUnit.Controls.Add(this.rdoMetric);
            this.grpUnit.Location = new System.Drawing.Point(506, 269);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(580, 67);
            this.grpUnit.TabIndex = 1;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rdoImperial
            // 
            this.rdoImperial.AutoSize = true;
            this.rdoImperial.Location = new System.Drawing.Point(300, 30);
            this.rdoImperial.Name = "rdoImperial";
            this.rdoImperial.Size = new System.Drawing.Size(160, 29);
            this.rdoImperial.TabIndex = 2;
            this.rdoImperial.TabStop = true;
            this.rdoImperial.Text = "Imperial (ft, lbs)";
            this.rdoImperial.UseVisualStyleBackColor = true;
            this.rdoImperial.CheckedChanged += new System.EventHandler(this.rdoImperial_CheckedChanged);
            // 
            // rdoMetric
            // 
            this.rdoMetric.AutoSize = true;
            this.rdoMetric.Location = new System.Drawing.Point(30, 30);
            this.rdoMetric.Name = "rdoMetric";
            this.rdoMetric.Size = new System.Drawing.Size(154, 29);
            this.rdoMetric.TabIndex = 1;
            this.rdoMetric.TabStop = true;
            this.rdoMetric.Text = "Metric (kg, cm)";
            this.rdoMetric.UseVisualStyleBackColor = true;
            this.rdoMetric.CheckedChanged += new System.EventHandler(this.rdoMetric_CheckedChanged);
            // 
            // btnCalculateWaterIntake
            // 
            this.btnCalculateWaterIntake.Location = new System.Drawing.Point(90, 258);
            this.btnCalculateWaterIntake.Name = "btnCalculateWaterIntake";
            this.btnCalculateWaterIntake.Size = new System.Drawing.Size(175, 34);
            this.btnCalculateWaterIntake.TabIndex = 2;
            this.btnCalculateWaterIntake.Text = "Calculate";
            this.btnCalculateWaterIntake.UseVisualStyleBackColor = true;
            this.btnCalculateWaterIntake.Click += new System.EventHandler(this.btnCalculateWaterIntake_Click);
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.txtName);
            this.grpPersonalInfo.Controls.Add(this.txtWeight);
            this.grpPersonalInfo.Controls.Add(this.lblHeight);
            this.grpPersonalInfo.Controls.Add(this.txtHeightIn);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Controls.Add(this.txtHeightFt);
            this.grpPersonalInfo.Controls.Add(this.lblWeight);
            this.grpPersonalInfo.Controls.Add(this.grpOtherData);
            this.grpPersonalInfo.Controls.Add(this.grpGender);
            this.grpPersonalInfo.Location = new System.Drawing.Point(17, 42);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(1143, 210);
            this.grpPersonalInfo.TabIndex = 1;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Info";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(191, 138);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(130, 31);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(15, 91);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(146, 25);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height (ft and in)";
            // 
            // txtHeightIn
            // 
            this.txtHeightIn.Location = new System.Drawing.Point(327, 91);
            this.txtHeightIn.Name = "txtHeightIn";
            this.txtHeightIn.Size = new System.Drawing.Size(132, 31);
            this.txtHeightIn.TabIndex = 3;
            this.txtHeightIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeightIn.Visible = true; // Initially visible, will be toggled by code
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtHeightFt
            // 
            this.txtHeightFt.Location = new System.Drawing.Point(191, 91);
            this.txtHeightFt.Name = "txtHeightFt";
            this.txtHeightFt.Size = new System.Drawing.Size(130, 31);
            this.txtHeightFt.TabIndex = 2;
            this.txtHeightFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(15, 144);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(106, 25);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (lbs)";
            // 
            // grpOtherData
            // 
            this.grpOtherData.Controls.Add(this.cmbActivityLevel);
            this.grpOtherData.Controls.Add(this.txtBirthYear);
            this.grpOtherData.Controls.Add(this.lblBirthYear);
            this.grpOtherData.Controls.Add(this.lblActivityLevel);
            this.grpOtherData.Location = new System.Drawing.Point(783, 39);
            this.grpOtherData.Name = "grpOtherData";
            this.grpOtherData.Size = new System.Drawing.Size(340, 150);
            this.grpOtherData.TabIndex = 3;
            this.grpOtherData.TabStop = false;
            this.grpOtherData.Text = "Other Data";
            // 
            // cmbActivityLevel
            // 
            this.cmbActivityLevel.FormattingEnabled = true;
            this.cmbActivityLevel.Items.AddRange(new object[] { "Low", "Medium", "High" });
            this.cmbActivityLevel.Location = new System.Drawing.Point(136, 52);
            this.cmbActivityLevel.Name = "cmbActivityLevel";
            this.cmbActivityLevel.Size = new System.Drawing.Size(182, 33);
            this.cmbActivityLevel.TabIndex = 1;
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(136, 102);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(150, 31);
            this.txtBirthYear.TabIndex = 5;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(6, 105);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(86, 25);
            this.lblBirthYear.TabIndex = 4;
            this.lblBirthYear.Text = "Birth year";
            // 
            // lblActivityLevel
            // 
            this.lblActivityLevel.AutoSize = true;
            this.lblActivityLevel.Location = new System.Drawing.Point(6, 52);
            this.lblActivityLevel.Name = "lblActivityLevel";
            this.lblActivityLevel.Size = new System.Drawing.Size(110, 25);
            this.lblActivityLevel.TabIndex = 3;
            this.lblActivityLevel.Text = "Activity level";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Location = new System.Drawing.Point(489, 39);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(252, 150);
            this.grpGender.TabIndex = 2;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 101);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(75, 29);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(6, 48);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(93, 29);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // grpRetirement
            // 
            this.grpRetirement.Controls.Add(this.btnCalculateRetirement);
            this.grpRetirement.Controls.Add(this.grpFutureValues);
            this.grpRetirement.Controls.Add(this.grpInvestment);
            this.grpRetirement.Controls.Add(this.grpRetirementData);
            this.grpRetirement.Location = new System.Drawing.Point(13, 509);
            this.grpRetirement.Name = "grpRetirement";
            this.grpRetirement.Size = new System.Drawing.Size(1178, 280);
            this.grpRetirement.TabIndex = 1;
            this.grpRetirement.TabStop = false;
            this.grpRetirement.Text = "Retirement Saving";
            // 
            // btnCalculateRetirement
            // 
            this.btnCalculateRetirement.Location = new System.Drawing.Point(257, 228);
            this.btnCalculateRetirement.Name = "btnCalculateRetirement";
            this.btnCalculateRetirement.Size = new System.Drawing.Size(209, 34);
            this.btnCalculateRetirement.TabIndex = 5;
            this.btnCalculateRetirement.Text = "Calculate";
            this.btnCalculateRetirement.UseVisualStyleBackColor = true;
            this.btnCalculateRetirement.Click += new System.EventHandler(this.btnCalculateRetirement_Click);
            // 
            // grpFutureValues
            // 
            this.grpFutureValues.Controls.Add(this.lblGrowthPercentage);
            this.grpFutureValues.Controls.Add(this.lblTotalInvestment);
            this.grpFutureValues.Controls.Add(this.lblTotalInterest);
            this.grpFutureValues.Controls.Add(this.lblTotalFutureAmount);
            this.grpFutureValues.Controls.Add(this.lblYearsToRetirement);
            this.grpFutureValues.Controls.Add(this.lblGrowthPercentageText);
            this.grpFutureValues.Controls.Add(this.lblTotalInvestmentText);
            this.grpFutureValues.Controls.Add(this.lblTotalInterestText);
            this.grpFutureValues.Controls.Add(this.lblTotalFutureAmountText);
            this.grpFutureValues.Controls.Add(this.lblYearsToRetirementText);
            this.grpFutureValues.Location = new System.Drawing.Point(747, 47);
            this.grpFutureValues.Name = "grpFutureValues";
            this.grpFutureValues.Size = new System.Drawing.Size(425, 227);
            this.grpFutureValues.TabIndex = 4;
            this.grpFutureValues.TabStop = false;
            this.grpFutureValues.Text = "Future Values";
            this.grpFutureValues.UseCompatibleTextRendering = true;
            // 
            // lblGrowthPercentage
            // 
            this.lblGrowthPercentage.AutoSize = true;
            this.lblGrowthPercentage.Location = new System.Drawing.Point(323, 190);
            this.lblGrowthPercentage.Name = "lblGrowthPercentage";
            this.lblGrowthPercentage.Size = new System.Drawing.Size(0, 25);
            this.lblGrowthPercentage.TabIndex = 18;
            // 
            // lblTotalInvestment
            // 
            this.lblTotalInvestment.AutoSize = true;
            this.lblTotalInvestment.Location = new System.Drawing.Point(307, 154);
            this.lblTotalInvestment.Name = "lblTotalInvestment";
            this.lblTotalInvestment.Size = new System.Drawing.Size(0, 25);
            this.lblTotalInvestment.TabIndex = 17;
            this.lblTotalInvestment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(302, 110);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(0, 25);
            this.lblTotalInterest.TabIndex = 16;
            this.lblTotalInterest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalInterest.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblTotalFutureAmount
            // 
            this.lblTotalFutureAmount.AutoSize = true;
            this.lblTotalFutureAmount.Location = new System.Drawing.Point(293, 73);
            this.lblTotalFutureAmount.Name = "lblTotalFutureAmount";
            this.lblTotalFutureAmount.Size = new System.Drawing.Size(0, 25);
            this.lblTotalFutureAmount.TabIndex = 15;
            this.lblTotalFutureAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblYearsToRetirement
            // 
            this.lblYearsToRetirement.AutoSize = true;
            this.lblYearsToRetirement.Location = new System.Drawing.Point(324, 34);
            this.lblYearsToRetirement.Name = "lblYearsToRetirement";
            this.lblYearsToRetirement.Size = new System.Drawing.Size(0, 25);
            this.lblYearsToRetirement.TabIndex = 14;
            this.lblYearsToRetirement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGrowthPercentageText
            // 
            this.lblGrowthPercentageText.AutoSize = true;
            this.lblGrowthPercentageText.Location = new System.Drawing.Point(19, 190);
            this.lblGrowthPercentageText.Name = "lblGrowthPercentageText";
            this.lblGrowthPercentageText.Size = new System.Drawing.Size(109, 25);
            this.lblGrowthPercentageText.TabIndex = 13;
            this.lblGrowthPercentageText.Text = "Growth in %";
            // 
            // lblTotalInvestmentText
            // 
            this.lblTotalInvestmentText.AutoSize = true;
            this.lblTotalInvestmentText.Location = new System.Drawing.Point(19, 154);
            this.lblTotalInvestmentText.Name = "lblTotalInvestmentText";
            this.lblTotalInvestmentText.Size = new System.Drawing.Size(142, 25);
            this.lblTotalInvestmentText.TabIndex = 12;
            this.lblTotalInvestmentText.Text = "Total Investment";
            // 
            // lblTotalInterestText
            // 
            this.lblTotalInterestText.AutoSize = true;
            this.lblTotalInterestText.Location = new System.Drawing.Point(19, 113);
            this.lblTotalInterestText.Name = "lblTotalInterestText";
            this.lblTotalInterestText.Size = new System.Drawing.Size(113, 25);
            this.lblTotalInterestText.TabIndex = 11;
            this.lblTotalInterestText.Text = "Total Interest";
            // 
            // lblTotalFutureAmountText
            // 
            this.lblTotalFutureAmountText.AutoSize = true;
            this.lblTotalFutureAmountText.Location = new System.Drawing.Point(19, 73);
            this.lblTotalFutureAmountText.Name = "lblTotalFutureAmountText";
            this.lblTotalFutureAmountText.Size = new System.Drawing.Size(174, 25);
            this.lblTotalFutureAmountText.TabIndex = 10;
            this.lblTotalFutureAmountText.Text = "Total Future Amount";
            // 
            // lblYearsToRetirementText
            // 
            this.lblYearsToRetirementText.AutoSize = true;
            this.lblYearsToRetirementText.Location = new System.Drawing.Point(19, 37);
            this.lblYearsToRetirementText.Name = "lblYearsToRetirementText";
            this.lblYearsToRetirementText.Size = new System.Drawing.Size(164, 25);
            this.lblYearsToRetirementText.TabIndex = 9;
            this.lblYearsToRetirementText.Text = "Years to Retirement";
            // 
            // grpInvestment
            // 
            this.grpInvestment.Controls.Add(this.txtAnnualInterest);
            this.grpInvestment.Controls.Add(this.txtMonthlySavings);
            this.grpInvestment.Controls.Add(this.lblAnnualInterest);
            this.grpInvestment.Controls.Add(this.txtCurrentSavings);
            this.grpInvestment.Controls.Add(this.lblMonthlySavings);
            this.grpInvestment.Controls.Add(this.lblCurrentSavings);
            this.grpInvestment.Location = new System.Drawing.Point(370, 47);
            this.grpInvestment.Name = "grpInvestment";
            this.grpInvestment.Size = new System.Drawing.Size(300, 150);
            this.grpInvestment.TabIndex = 3;
            this.grpInvestment.TabStop = false;
            this.grpInvestment.Text = "Investment";
            // 
            // txtAnnualInterest
            // 
            this.txtAnnualInterest.Location = new System.Drawing.Point(165, 110);
            this.txtAnnualInterest.Name = "txtAnnualInterest";
            this.txtAnnualInterest.Size = new System.Drawing.Size(129, 31);
            this.txtAnnualInterest.TabIndex = 6;
            // 
            // txtMonthlySavings
            // 
            this.txtMonthlySavings.Location = new System.Drawing.Point(165, 73);
            this.txtMonthlySavings.Name = "txtMonthlySavings";
            this.txtMonthlySavings.Size = new System.Drawing.Size(129, 31);
            this.txtMonthlySavings.TabIndex = 6;
            // 
            // lblAnnualInterest
            // 
            this.lblAnnualInterest.AutoSize = true;
            this.lblAnnualInterest.Location = new System.Drawing.Point(6, 110);
            this.lblAnnualInterest.Name = "lblAnnualInterest";
            this.lblAnnualInterest.Size = new System.Drawing.Size(160, 25);
            this.lblAnnualInterest.TabIndex = 8;
            this.lblAnnualInterest.Text = "Annual interest (%)";
            // 
            // txtCurrentSavings
            // 
            this.txtCurrentSavings.Location = new System.Drawing.Point(165, 34);
            this.txtCurrentSavings.Name = "txtCurrentSavings";
            this.txtCurrentSavings.Size = new System.Drawing.Size(129, 31);
            this.txtCurrentSavings.TabIndex = 5;
            // 
            // lblMonthlySavings
            // 
            this.lblMonthlySavings.AutoSize = true;
            this.lblMonthlySavings.Location = new System.Drawing.Point(6, 73);
            this.lblMonthlySavings.Name = "lblMonthlySavings";
            this.lblMonthlySavings.Size = new System.Drawing.Size(142, 25);
            this.lblMonthlySavings.TabIndex = 7;
            this.lblMonthlySavings.Text = "Monthly savings";
            // 
            // lblCurrentSavings
            // 
            this.lblCurrentSavings.AutoSize = true;
            this.lblCurrentSavings.Location = new System.Drawing.Point(6, 37);
            this.lblCurrentSavings.Name = "lblCurrentSavings";
            this.lblCurrentSavings.Size = new System.Drawing.Size(134, 25);
            this.lblCurrentSavings.TabIndex = 6;
            this.lblCurrentSavings.Text = "Current savings";
            // 
            // grpRetirementData
            // 
            this.grpRetirementData.Controls.Add(this.cmbRetiringAge);
            this.grpRetirementData.Controls.Add(this.lblRetiringAge);
            this.grpRetirementData.Location = new System.Drawing.Point(16, 47);
            this.grpRetirementData.Name = "grpRetirementData";
            this.grpRetirementData.Size = new System.Drawing.Size(305, 150);
            this.grpRetirementData.TabIndex = 2;
            this.grpRetirementData.TabStop = false;
            this.grpRetirementData.Text = "Retirement Data";
            // 
            // cmbRetiringAge
            // 
            this.cmbRetiringAge.FormattingEnabled = true;
            this.cmbRetiringAge.Items.AddRange(new object[] { "55", "60", "65", "70" });
            this.cmbRetiringAge.Location = new System.Drawing.Point(149, 34);
            this.cmbRetiringAge.Name = "cmbRetiringAge";
            this.cmbRetiringAge.Size = new System.Drawing.Size(150, 33);
            this.cmbRetiringAge.TabIndex = 5;
            // 
            // lblRetiringAge
            // 
            this.lblRetiringAge.AutoSize = true;
            this.lblRetiringAge.Location = new System.Drawing.Point(15, 37);
            this.lblRetiringAge.Name = "lblRetiringAge";
            this.lblRetiringAge.Size = new System.Drawing.Size(109, 25);
            this.lblRetiringAge.TabIndex = 5;
            this.lblRetiringAge.Text = "Retiring Age";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1217, 798);
            this.Controls.Add(this.grpRetirement);
            this.Controls.Add(this.grpWaterIntake);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Super Calculator by Ibrahim";
            this.grpWaterIntake.ResumeLayout(false);
            this.grpRecommendedWater.ResumeLayout(false);
            this.grpRecommendedWater.PerformLayout();
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpOtherData.ResumeLayout(false);
            this.grpOtherData.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpRetirement.ResumeLayout(false);
            this.grpFutureValues.ResumeLayout(false);
            this.grpFutureValues.PerformLayout();
            this.grpInvestment.ResumeLayout(false);
            this.grpInvestment.PerformLayout();
            this.grpRetirementData.ResumeLayout(false);
            this.grpRetirementData.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpWaterIntake;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.GroupBox grpOtherData;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeightIn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtHeightFt;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblActivityLevel;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.ComboBox cmbActivityLevel;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rdoImperial;
        private System.Windows.Forms.RadioButton rdoMetric;
        private System.Windows.Forms.Button btnCalculateWaterIntake;
        private System.Windows.Forms.GroupBox grpRecommendedWater;
        private System.Windows.Forms.Label lblWaterIntakeGlasses;
        private System.Windows.Forms.Label lblDailyWaterIntake;
        private System.Windows.Forms.Label lblWaterIntakeOunces;
        private System.Windows.Forms.GroupBox grpRetirement;
        private System.Windows.Forms.Label lblTotalInterestText;
        private System.Windows.Forms.Label lblTotalFutureAmountText;
        private System.Windows.Forms.Label lblYearsToRetirementText;
        private System.Windows.Forms.Label lblAnnualInterest;
        private System.Windows.Forms.Label lblMonthlySavings;
        private System.Windows.Forms.Label lblCurrentSavings;
        private System.Windows.Forms.Label lblRetiringAge;
        private System.Windows.Forms.GroupBox grpFutureValues;
        private System.Windows.Forms.GroupBox grpInvestment;
        private System.Windows.Forms.GroupBox grpRetirementData;
        private System.Windows.Forms.Label lblTotalInvestmentText;
        private System.Windows.Forms.TextBox txtAnnualInterest;
        private System.Windows.Forms.TextBox txtMonthlySavings;
        private System.Windows.Forms.TextBox txtCurrentSavings;
        private System.Windows.Forms.ComboBox cmbRetiringAge;
        private System.Windows.Forms.Button btnCalculateRetirement;
        private System.Windows.Forms.Label lblGrowthPercentage;
        private System.Windows.Forms.Label lblTotalInvestment;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalFutureAmount;
        private System.Windows.Forms.Label lblYearsToRetirement;
        private System.Windows.Forms.Label lblGrowthPercentageText;
    }
}