using System;
using System.Globalization;
using System.Windows.Forms;

namespace A3
{
    public partial class MainForm : Form
    {
        private Person person;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize default values for combo boxes
            cmbActivityLevel.Items.AddRange(new string[] { "Low", "Medium", "High" });
            cmbRetiringAge.Items.AddRange(new string[] { "55", "60", "65", "70" });

            // Initialize dynamic labels to empty
            lblYearsToRetirement.Text = "";
            lblTotalFutureAmount.Text = "";
            lblTotalInterest.Text = "";
            lblTotalInvestment.Text = "";
            lblGrowthPercentage.Text = "";

            lblWaterIntakeOunces.Text = "";
            lblWaterIntakeGlasses.Text = "";

            // Ensure all GroupBoxes are enabled
            grpWaterIntake.Enabled = true;
            grpRecommendedWater.Enabled = true;
            grpPersonalInfo.Enabled = true;
            grpOtherData.Enabled = true;
            grpGender.Enabled = true;
            grpUnit.Enabled = true;
            grpRetirement.Enabled = true;
            grpInvestment.Enabled = true;
            grpRetirementData.Enabled = true;
            grpFutureValues.Enabled = true;
        }

        // Button Click Event for Water Intake Calculation
        private void btnCalculateWaterIntake_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHeightFt.Text) || string.IsNullOrWhiteSpace(txtHeightIn.Text) || // Check for empty fields
                    string.IsNullOrWhiteSpace(txtWeight.Text) || cmbActivityLevel.SelectedItem == null || // 
                    string.IsNullOrWhiteSpace(txtBirthYear.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Display error message
                    return;
                }

                double heightFt = double.Parse(txtHeightFt.Text, CultureInfo.InvariantCulture); // Parse height in feet
                double heightIn = double.Parse(txtHeightIn.Text, CultureInfo.InvariantCulture); // Parse height in inches
                double weight = double.Parse(txtWeight.Text, CultureInfo.InvariantCulture); // Parse weight
                string activityLevel = cmbActivityLevel.SelectedItem.ToString(); // Get selected activity level
                int birthYear = int.Parse(txtBirthYear.Text);   // Parse birth year

                double totalHeightInches = (heightFt * 12) + heightIn; // Convert height to total inches
                int currentYear = DateTime.Now.Year; // Get current year
                int age = currentYear - birthYear; // Calculate age

                person = new Person(totalHeightInches, weight, birthYear, "", activityLevel); // Create new Person object
                WaterIntakeCalculator calculator = new WaterIntakeCalculator(person);   // Create new WaterIntakeCalculator object

                double dailyWaterMl = calculator.CalculateDailyWaterIntakeMl(); // Calculate daily water intake in milliliters
                double dailyWaterOunces = calculator.GetWaterIntakeInOunces(); // Convert milliliters to ounces
                int dailyWaterGlasses = calculator.GetWaterIntakeInGlasses(); // Convert milliliters to glasses

                lblWaterIntakeOunces.Text = dailyWaterOunces.ToString("0.0") + " ounces"; // Display daily water intake in ounces
                lblWaterIntakeGlasses.Text = dailyWaterGlasses.ToString() + " glasses";     // Display daily water intake in glasses
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Display error message
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display error message
            }
        }
        // Button Click Event for Retirement Savings Calculation
        private void btnCalculateRetirement_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRetiringAge.SelectedItem == null || string.IsNullOrWhiteSpace(txtCurrentSavings.Text) || // Check for empty fields
                    string.IsNullOrWhiteSpace(txtMonthlySavings.Text) || string.IsNullOrWhiteSpace(txtAnnualInterest.Text) ||
                    string.IsNullOrWhiteSpace(txtBirthYear.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Display error message
                    return;
                }

                int retiringAge = int.Parse(cmbRetiringAge.SelectedItem.ToString()); // Parse retiring age
                double currentSavings = double.Parse(txtCurrentSavings.Text); // Parse current savings
                double monthlySavings = double.Parse(txtMonthlySavings.Text); // Parse monthly savings
                double annualInterestRate = double.Parse(txtAnnualInterest.Text, CultureInfo.InvariantCulture) / 100; // Parse annual interest rate
                int birthYear = int.Parse(txtBirthYear.Text); // Parse birth year
                int currentYear = DateTime.Now.Year; // Get current year
                int currentAge = currentYear - birthYear; // Calculate current age

                int yearsToRetirement = retiringAge - currentAge; // Calculate years to retirement
                if (yearsToRetirement < 0) // Check if retirement age is valid
                {
                    MessageBox.Show("Retirement age must be greater than current age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Display error message
                    return;
                }

                person = new Person(0, 0, birthYear, "", ""); // Create new Person object
                RetirementSavingCalculator calculator = new RetirementSavingCalculator(person, currentSavings, monthlySavings, annualInterestRate, retiringAge); // Create new RetirementSavingCalculator object

                double totalFutureAmount = calculator.CalculateFutureSavings(); // Calculate total future savings
                double totalInterest = calculator.CalculateTotalInterest(); // Calculate total interest earned
                double totalInvestment = currentSavings + (monthlySavings * 12 * yearsToRetirement); // Calculate total investment
                double growthPercentage = (totalInterest / totalInvestment) * 100; // Calculate growth percentage

                lblYearsToRetirement.Text = yearsToRetirement.ToString() + " years"; // Display years to retirement
                lblTotalFutureAmount.Text = totalFutureAmount.ToString("C"); // Display total future amount
                lblTotalInterest.Text = totalInterest.ToString("C"); // Display total interest
                lblTotalInvestment.Text = totalInvestment.ToString("C"); // Display total investment
                lblGrowthPercentage.Text = growthPercentage.ToString("0.0") + "%"; // Display growth percentage
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Display error message
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display error message
            }
        }
        private void InitializeComponent() 
        {
            grpWaterIntake = new GroupBox();
            grpRecommendedWater = new GroupBox();
            lblWaterIntakeGlasses = new Label();
            lblDailyWaterIntake = new Label();
            lblWaterIntakeOunces = new Label();
            grpUnit = new GroupBox();
            rdoImperial = new RadioButton();
            rdoMetric = new RadioButton();
            btnCalculateWaterIntake = new Button();
            grpPersonalInfo = new GroupBox();
            txtName = new TextBox();
            txtWeight = new TextBox();
            lblHeight = new Label();
            txtHeightIn = new TextBox();
            lblName = new Label();
            txtHeightFt = new TextBox();
            lblWeight = new Label();
            grpOtherData = new GroupBox();
            cmbActivityLevel = new ComboBox();
            txtBirthYear = new TextBox();
            lblBirthYear = new Label();
            lblActivityLevel = new Label();
            grpGender = new GroupBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            grpRetirement = new GroupBox();
            btnCalculateRetirement = new Button();
            grpFutureValues = new GroupBox();
            lblGrowthPercentage = new Label();
            lblTotalInvestment = new Label();
            lblTotalInterest = new Label();
            lblTotalFutureAmount = new Label();
            lblYearsToRetirement = new Label();
            lblGrowthPercentageText = new Label();
            lblTotalInvestmentText = new Label();
            lblTotalInterestText = new Label();
            lblTotalFutureAmountText = new Label();
            lblYearsToRetirementText = new Label();
            grpInvestment = new GroupBox();
            txtAnnualInterest = new TextBox();
            txtMonthlySavings = new TextBox();
            lblAnnualInterest = new Label();
            txtCurrentSavings = new TextBox();
            lblMonthlySavings = new Label();
            lblCurrentSavings = new Label();
            grpRetirementData = new GroupBox();
            cmbRetiringAge = new ComboBox();
            lblRetiringAge = new Label();
            grpWaterIntake.SuspendLayout();
            grpRecommendedWater.SuspendLayout();
            grpUnit.SuspendLayout();
            grpPersonalInfo.SuspendLayout();
            grpOtherData.SuspendLayout();
            grpGender.SuspendLayout();
            grpRetirement.SuspendLayout();
            grpFutureValues.SuspendLayout();
            grpInvestment.SuspendLayout();
            grpRetirementData.SuspendLayout();
            SuspendLayout();
            // 
            // grpWaterIntake
            // 
            grpWaterIntake.Controls.Add(grpRecommendedWater);
            grpWaterIntake.Controls.Add(grpUnit);
            grpWaterIntake.Controls.Add(btnCalculateWaterIntake);
            grpWaterIntake.Controls.Add(grpPersonalInfo);
            grpWaterIntake.Location = new Point(12, 32);
            grpWaterIntake.Name = "grpWaterIntake";
            grpWaterIntake.Size = new Size(1179, 453);
            grpWaterIntake.TabIndex = 0;
            grpWaterIntake.TabStop = false;
            grpWaterIntake.Text = "Daily Water Intake";
            // 
            // grpRecommendedWater
            // 
            grpRecommendedWater.Controls.Add(lblWaterIntakeGlasses);
            grpRecommendedWater.Controls.Add(lblDailyWaterIntake);
            grpRecommendedWater.Controls.Add(lblWaterIntakeOunces);
            grpRecommendedWater.Location = new Point(17, 354);
            grpRecommendedWater.Name = "grpRecommendedWater";
            grpRecommendedWater.Size = new Size(1069, 79);
            grpRecommendedWater.TabIndex = 1;
            grpRecommendedWater.TabStop = false;
            grpRecommendedWater.Text = "Recommended Daily Water Consumption";
            grpRecommendedWater.Enter += grpRecommendedWater_Enter;
            // 
            // lblWaterIntakeGlasses
            // 
            lblWaterIntakeGlasses.AutoSize = true;
            lblWaterIntakeGlasses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaterIntakeGlasses.ForeColor = SystemColors.Highlight;
            lblWaterIntakeGlasses.Location = new Point(707, 41);
            lblWaterIntakeGlasses.Name = "lblWaterIntakeGlasses";
            lblWaterIntakeGlasses.Size = new Size(0, 25);
            lblWaterIntakeGlasses.TabIndex = 3;
            lblWaterIntakeGlasses.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDailyWaterIntake
            // 
            lblDailyWaterIntake.AutoSize = true;
            lblDailyWaterIntake.Location = new Point(15, 41);
            lblDailyWaterIntake.Name = "lblDailyWaterIntake";
            lblDailyWaterIntake.Size = new Size(151, 25);
            lblDailyWaterIntake.TabIndex = 1;
            lblDailyWaterIntake.Text = "Daily water intake";
            // 
            // lblWaterIntakeOunces
            // 
            lblWaterIntakeOunces.AutoSize = true;
            lblWaterIntakeOunces.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaterIntakeOunces.ForeColor = SystemColors.Highlight;
            lblWaterIntakeOunces.Location = new Point(284, 41);
            lblWaterIntakeOunces.Name = "lblWaterIntakeOunces";
            lblWaterIntakeOunces.Size = new Size(0, 25);
            lblWaterIntakeOunces.TabIndex = 2;
            lblWaterIntakeOunces.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpUnit
            // 
            grpUnit.Controls.Add(rdoImperial);
            grpUnit.Controls.Add(rdoMetric);
            grpUnit.Location = new Point(506, 269);
            grpUnit.Name = "grpUnit";
            grpUnit.Size = new Size(580, 67);
            grpUnit.TabIndex = 1;
            grpUnit.TabStop = false;
            grpUnit.Text = "Unit";
            // 
            // rdoImperial
            // 
            rdoImperial.AutoSize = true;
            rdoImperial.Location = new Point(300, 30);
            rdoImperial.Name = "rdoImperial";
            rdoImperial.Size = new Size(160, 29);
            rdoImperial.TabIndex = 2;
            rdoImperial.TabStop = true;
            rdoImperial.Text = "Imperial (ft, lbs)";
            rdoImperial.UseVisualStyleBackColor = true;
            // 
            // rdoMetric
            // 
            rdoMetric.AutoSize = true;
            rdoMetric.Location = new Point(30, 30);
            rdoMetric.Name = "rdoMetric";
            rdoMetric.Size = new Size(154, 29);
            rdoMetric.TabIndex = 1;
            rdoMetric.TabStop = true;
            rdoMetric.Text = "Metric (kg, cm)";
            rdoMetric.UseVisualStyleBackColor = true;
            // 
            // btnCalculateWaterIntake
            // 
            btnCalculateWaterIntake.Location = new Point(90, 258);
            btnCalculateWaterIntake.Name = "btnCalculateWaterIntake";
            btnCalculateWaterIntake.Size = new Size(175, 34);
            btnCalculateWaterIntake.TabIndex = 2;
            btnCalculateWaterIntake.Text = "Calculate";
            btnCalculateWaterIntake.UseVisualStyleBackColor = true;
            btnCalculateWaterIntake.Click += btnCalculateWaterIntake_Click;
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(txtName);
            grpPersonalInfo.Controls.Add(txtWeight);
            grpPersonalInfo.Controls.Add(lblHeight);
            grpPersonalInfo.Controls.Add(txtHeightIn);
            grpPersonalInfo.Controls.Add(lblName);
            grpPersonalInfo.Controls.Add(txtHeightFt);
            grpPersonalInfo.Controls.Add(lblWeight);
            grpPersonalInfo.Controls.Add(grpOtherData);
            grpPersonalInfo.Controls.Add(grpGender);
            grpPersonalInfo.Location = new Point(17, 42);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(1143, 210);
            grpPersonalInfo.TabIndex = 1;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Personal Info";
            // 
            // txtName
            // 
            txtName.Location = new Point(191, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 31);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(191, 138);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(130, 31);
            txtWeight.TabIndex = 4;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(15, 91);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(146, 25);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Height (ft and in)";
            // 
            // txtHeightIn
            // 
            txtHeightIn.Location = new Point(327, 91);
            txtHeightIn.Name = "txtHeightIn";
            txtHeightIn.Size = new Size(132, 31);
            txtHeightIn.TabIndex = 3;
            txtHeightIn.TextAlign = HorizontalAlignment.Right;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtHeightFt
            // 
            txtHeightFt.Location = new Point(191, 91);
            txtHeightFt.Name = "txtHeightFt";
            txtHeightFt.Size = new Size(130, 31);
            txtHeightFt.TabIndex = 2;
            txtHeightFt.TextAlign = HorizontalAlignment.Right;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(15, 144);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(106, 25);
            lblWeight.TabIndex = 2;
            lblWeight.Text = "Weight (lbs)";
            // 
            // grpOtherData
            // 
            grpOtherData.Controls.Add(cmbActivityLevel);
            grpOtherData.Controls.Add(txtBirthYear);
            grpOtherData.Controls.Add(lblBirthYear);
            grpOtherData.Controls.Add(lblActivityLevel);
            grpOtherData.Location = new Point(783, 39);
            grpOtherData.Name = "grpOtherData";
            grpOtherData.Size = new Size(340, 150);
            grpOtherData.TabIndex = 3;
            grpOtherData.TabStop = false;
            grpOtherData.Text = "Other Data";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Items.AddRange(new object[] { "Low", "Medium ", "High" });
            cmbActivityLevel.Location = new Point(136, 52);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(182, 33);
            cmbActivityLevel.TabIndex = 1;
            // 
            // txtBirthYear
            // 
            txtBirthYear.Location = new Point(136, 102);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(150, 31);
            txtBirthYear.TabIndex = 5;
            // 
            // lblBirthYear
            // 
            lblBirthYear.AutoSize = true;
            lblBirthYear.Location = new Point(6, 105);
            lblBirthYear.Name = "lblBirthYear";
            lblBirthYear.Size = new Size(86, 25);
            lblBirthYear.TabIndex = 4;
            lblBirthYear.Text = "Birth year";
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Location = new Point(6, 52);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(110, 25);
            lblActivityLevel.TabIndex = 3;
            lblActivityLevel.Text = "Activity level";
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoMale);
            grpGender.Controls.Add(rdoFemale);
            grpGender.Location = new Point(489, 39);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(252, 150);
            grpGender.TabIndex = 2;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(6, 101);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 3;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(6, 48);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 2;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // grpRetirement
            // 
            grpRetirement.Controls.Add(btnCalculateRetirement);
            grpRetirement.Controls.Add(grpFutureValues);
            grpRetirement.Controls.Add(grpInvestment);
            grpRetirement.Controls.Add(grpRetirementData);
            grpRetirement.Location = new Point(13, 509);
            grpRetirement.Name = "grpRetirement";
            grpRetirement.Size = new Size(1178, 280);
            grpRetirement.TabIndex = 1;
            grpRetirement.TabStop = false;
            grpRetirement.Text = "Retirement Saving";
            // 
            // btnCalculateRetirement
            // 
            btnCalculateRetirement.Location = new Point(257, 228);
            btnCalculateRetirement.Name = "btnCalculateRetirement";
            btnCalculateRetirement.Size = new Size(209, 34);
            btnCalculateRetirement.TabIndex = 5;
            btnCalculateRetirement.Text = "Calculate";
            btnCalculateRetirement.UseVisualStyleBackColor = true;
            btnCalculateRetirement.Click += btnCalculateRetirement_Click;
            // 
            // grpFutureValues
            // 
            grpFutureValues.Controls.Add(lblGrowthPercentage);
            grpFutureValues.Controls.Add(lblTotalInvestment);
            grpFutureValues.Controls.Add(lblTotalInterest);
            grpFutureValues.Controls.Add(lblTotalFutureAmount);
            grpFutureValues.Controls.Add(lblYearsToRetirement);
            grpFutureValues.Controls.Add(lblGrowthPercentageText);
            grpFutureValues.Controls.Add(lblTotalInvestmentText);
            grpFutureValues.Controls.Add(lblTotalInterestText);
            grpFutureValues.Controls.Add(lblTotalFutureAmountText);
            grpFutureValues.Controls.Add(lblYearsToRetirementText);
            grpFutureValues.Location = new Point(747, 47);
            grpFutureValues.Name = "grpFutureValues";
            grpFutureValues.Size = new Size(425, 227);
            grpFutureValues.TabIndex = 4;
            grpFutureValues.TabStop = false;
            grpFutureValues.Text = "Future Values";
            grpFutureValues.UseCompatibleTextRendering = true;
            // 
            // lblGrowthPercentage
            // 
            lblGrowthPercentage.AutoSize = true;
            lblGrowthPercentage.Location = new Point(323, 190);
            lblGrowthPercentage.Name = "lblGrowthPercentage";
            lblGrowthPercentage.Size = new Size(0, 25);
            lblGrowthPercentage.TabIndex = 18;
            // 
            // lblTotalInvestment
            // 
            lblTotalInvestment.AutoSize = true;
            lblTotalInvestment.Location = new Point(307, 154);
            lblTotalInvestment.Name = "lblTotalInvestment";
            lblTotalInvestment.Size = new Size(0, 25);
            lblTotalInvestment.TabIndex = 17;
            lblTotalInvestment.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotalInterest
            // 
            lblTotalInterest.AutoSize = true;
            lblTotalInterest.Location = new Point(302, 110);
            lblTotalInterest.Name = "lblTotalInterest";
            lblTotalInterest.Size = new Size(0, 25);
            lblTotalInterest.TabIndex = 16;
            lblTotalInterest.TextAlign = ContentAlignment.TopRight;
            lblTotalInterest.Click += label12_Click;
            // 
            // lblTotalFutureAmount
            // 
            lblTotalFutureAmount.AutoSize = true;
            lblTotalFutureAmount.Location = new Point(293, 73);
            lblTotalFutureAmount.Name = "lblTotalFutureAmount";
            lblTotalFutureAmount.Size = new Size(0, 25);
            lblTotalFutureAmount.TabIndex = 15;
            lblTotalFutureAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // lblYearsToRetirement
            // 
            lblYearsToRetirement.AutoSize = true;
            lblYearsToRetirement.Location = new Point(324, 34);
            lblYearsToRetirement.Name = "lblYearsToRetirement";
            lblYearsToRetirement.Size = new Size(0, 25);
            lblYearsToRetirement.TabIndex = 14;
            lblYearsToRetirement.TextAlign = ContentAlignment.TopRight;
            // 
            // lblGrowthPercentageText
            // 
            lblGrowthPercentageText.AutoSize = true;
            lblGrowthPercentageText.Location = new Point(19, 190);
            lblGrowthPercentageText.Name = "lblGrowthPercentageText";
            lblGrowthPercentageText.Size = new Size(109, 25);
            lblGrowthPercentageText.TabIndex = 13;
            lblGrowthPercentageText.Text = "Growth in %";
            // 
            // lblTotalInvestmentText
            // 
            lblTotalInvestmentText.AutoSize = true;
            lblTotalInvestmentText.Location = new Point(19, 154);
            lblTotalInvestmentText.Name = "lblTotalInvestmentText";
            lblTotalInvestmentText.Size = new Size(142, 25);
            lblTotalInvestmentText.TabIndex = 12;
            lblTotalInvestmentText.Text = "Total Investment";
            // 
            // lblTotalInterestText
            // 
            lblTotalInterestText.AutoSize = true;
            lblTotalInterestText.Location = new Point(19, 113);
            lblTotalInterestText.Name = "lblTotalInterestText";
            lblTotalInterestText.Size = new Size(113, 25);
            lblTotalInterestText.TabIndex = 11;
            lblTotalInterestText.Text = "Total Interest";
            // 
            // lblTotalFutureAmountText
            // 
            lblTotalFutureAmountText.AutoSize = true;
            lblTotalFutureAmountText.Location = new Point(19, 73);
            lblTotalFutureAmountText.Name = "lblTotalFutureAmountText";
            lblTotalFutureAmountText.Size = new Size(174, 25);
            lblTotalFutureAmountText.TabIndex = 10;
            lblTotalFutureAmountText.Text = "Total Future Amount";
            // 
            // lblYearsToRetirementText
            // 
            lblYearsToRetirementText.AutoSize = true;
            lblYearsToRetirementText.Location = new Point(19, 37);
            lblYearsToRetirementText.Name = "lblYearsToRetirementText";
            lblYearsToRetirementText.Size = new Size(164, 25);
            lblYearsToRetirementText.TabIndex = 9;
            lblYearsToRetirementText.Text = "Years to Retirement";
            // 
            // grpInvestment
            // 
            grpInvestment.Controls.Add(txtAnnualInterest);
            grpInvestment.Controls.Add(txtMonthlySavings);
            grpInvestment.Controls.Add(lblAnnualInterest);
            grpInvestment.Controls.Add(txtCurrentSavings);
            grpInvestment.Controls.Add(lblMonthlySavings);
            grpInvestment.Controls.Add(lblCurrentSavings);
            grpInvestment.Location = new Point(370, 47);
            grpInvestment.Name = "grpInvestment";
            grpInvestment.Size = new Size(300, 150);
            grpInvestment.TabIndex = 3;
            grpInvestment.TabStop = false;
            grpInvestment.Text = "Investment";
            // 
            // txtAnnualInterest
            // 
            txtAnnualInterest.Location = new Point(165, 110);
            txtAnnualInterest.Name = "txtAnnualInterest";
            txtAnnualInterest.Size = new Size(129, 31);
            txtAnnualInterest.TabIndex = 6;
            // 
            // txtMonthlySavings
            // 
            txtMonthlySavings.Location = new Point(165, 73);
            txtMonthlySavings.Name = "txtMonthlySavings";
            txtMonthlySavings.Size = new Size(129, 31);
            txtMonthlySavings.TabIndex = 6;
            // 
            // lblAnnualInterest
            // 
            lblAnnualInterest.AutoSize = true;
            lblAnnualInterest.Location = new Point(6, 110);
            lblAnnualInterest.Name = "lblAnnualInterest";
            lblAnnualInterest.Size = new Size(160, 25);
            lblAnnualInterest.TabIndex = 8;
            lblAnnualInterest.Text = "Annual interest (%)";
            // 
            // txtCurrentSavings
            // 
            txtCurrentSavings.Location = new Point(165, 34);
            txtCurrentSavings.Name = "txtCurrentSavings";
            txtCurrentSavings.Size = new Size(129, 31);
            txtCurrentSavings.TabIndex = 5;
            // 
            // lblMonthlySavings
            // 
            lblMonthlySavings.AutoSize = true;
            lblMonthlySavings.Location = new Point(6, 73);
            lblMonthlySavings.Name = "lblMonthlySavings";
            lblMonthlySavings.Size = new Size(142, 25);
            lblMonthlySavings.TabIndex = 7;
            lblMonthlySavings.Text = "Monthly savings";
            // 
            // lblCurrentSavings
            // 
            lblCurrentSavings.AutoSize = true;
            lblCurrentSavings.Location = new Point(6, 37);
            lblCurrentSavings.Name = "lblCurrentSavings";
            lblCurrentSavings.Size = new Size(134, 25);
            lblCurrentSavings.TabIndex = 6;
            lblCurrentSavings.Text = "Current savings";
            // 
            // grpRetirementData
            // 
            grpRetirementData.Controls.Add(cmbRetiringAge);
            grpRetirementData.Controls.Add(lblRetiringAge);
            grpRetirementData.Location = new Point(16, 47);
            grpRetirementData.Name = "grpRetirementData";
            grpRetirementData.Size = new Size(305, 150);
            grpRetirementData.TabIndex = 2;
            grpRetirementData.TabStop = false;
            grpRetirementData.Text = "Retirement Data";
            // 
            // cmbRetiringAge
            // 
            cmbRetiringAge.FormattingEnabled = true;
            cmbRetiringAge.Items.AddRange(new object[] { "55", "60", "65", "70" });
            cmbRetiringAge.Location = new Point(149, 34);
            cmbRetiringAge.Name = "cmbRetiringAge";
            cmbRetiringAge.Size = new Size(150, 33);
            cmbRetiringAge.TabIndex = 5;
            // 
            // lblRetiringAge
            // 
            lblRetiringAge.AutoSize = true;
            lblRetiringAge.Location = new Point(15, 37);
            lblRetiringAge.Name = "lblRetiringAge";
            lblRetiringAge.Size = new Size(109, 25);
            lblRetiringAge.TabIndex = 5;
            lblRetiringAge.Text = "Retiring Age";
            // 
            // MainForm
            // 
            ClientSize = new Size(1217, 798);
            Controls.Add(grpRetirement);
            Controls.Add(grpWaterIntake);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Super Calculator by Ibrahim";
            grpWaterIntake.ResumeLayout(false);
            grpRecommendedWater.ResumeLayout(false);
            grpRecommendedWater.PerformLayout();
            grpUnit.ResumeLayout(false);
            grpUnit.PerformLayout();
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpOtherData.ResumeLayout(false);
            grpOtherData.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpRetirement.ResumeLayout(false);
            grpFutureValues.ResumeLayout(false);
            grpFutureValues.PerformLayout();
            grpInvestment.ResumeLayout(false);
            grpInvestment.PerformLayout();
            grpRetirementData.ResumeLayout(false);
            grpRetirementData.PerformLayout();
            ResumeLayout(false);

        }

        private void groupBox6_Enter(object sender, EventArgs e) { }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void grpRecommendedWater_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculateWaterIntake_Click_1(object sender, EventArgs e)
        {

        }

        private GroupBox grpWaterIntake;
        private GroupBox grpPersonalInfo;
        private GroupBox grpOtherData;
        private GroupBox grpGender;
        private TextBox txtName;
        private Label lblHeight;
        private TextBox txtHeightIn;
        private Label lblName;
        private TextBox txtHeightFt;
        private Label lblWeight;
        private Label lblBirthYear;
        private Label lblActivityLevel;
        private TextBox txtWeight;
        private TextBox txtBirthYear;
        private ComboBox cmbActivityLevel;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private GroupBox grpUnit;
        private RadioButton rdoImperial;
        private RadioButton rdoMetric;
        private Button btnCalculateWaterIntake;
        private GroupBox grpRecommendedWater;
        private Label lblWaterIntakeGlasses;
        private Label lblDailyWaterIntake;
        private Label lblWaterIntakeOunces;
        private GroupBox grpRetirement;
        private Label lblTotalInterestText;
        private Label lblTotalFutureAmountText;
        private Label lblYearsToRetirementText;
        private Label lblAnnualInterest;
        private Label lblMonthlySavings;
        private Label lblCurrentSavings;
        private Label lblRetiringAge;
        private GroupBox grpFutureValues;
        private GroupBox grpInvestment;
        private GroupBox grpRetirementData;
        private Label lblTotalInvestmentText;
        private TextBox txtAnnualInterest;
        private TextBox txtMonthlySavings;
        private TextBox txtCurrentSavings;
        private ComboBox cmbRetiringAge;
        private Button btnCalculateRetirement;
        private Label lblGrowthPercentage;
        private Label lblTotalInvestment;
        private Label lblTotalInterest;
        private Label lblTotalFutureAmount;
        private Label lblYearsToRetirement;
        private Label lblGrowthPercentageText;

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
