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
            lblDailyWaterIntake.Text = "Daily Water Intake";
            grpRecommendedWater.Text = "Recommended Daily Water Consumption"; // Set default GroupBox title

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

            // Set default unit to Imperial
            rdoImperial.Checked = true;
            UpdateUnitLabelsAndFields();
        }

        private void UpdateUnitLabelsAndFields()
        {
            if (rdoMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtHeightIn.Visible = false;
            }
            else // Imperial
            {
                lblHeight.Text = "Height (ft and in)";
                lblWeight.Text = "Weight (lbs)";
                txtHeightIn.Visible = true;
            }
        }

        private void rdoMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnitLabelsAndFields();
        }

        private void rdoImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnitLabelsAndFields();
        }

        // Button Click Event for Water Intake Calculation
        private void btnCalculateWaterIntake_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtHeightFt.Text) ||
                    (rdoImperial.Checked && string.IsNullOrWhiteSpace(txtHeightIn.Text)) ||
                    string.IsNullOrWhiteSpace(txtWeight.Text) ||
                    cmbActivityLevel.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtBirthYear.Text) ||
                    (!rdoMale.Checked && !rdoFemale.Checked))
                {
                    MessageBox.Show("Please fill in all required fields, including gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse inputs using TryParse
                if (!double.TryParse(txtHeightFt.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double heightFt))
                {
                    MessageBox.Show("Invalid height format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double heightIn = 0;
                if (rdoImperial.Checked && !double.TryParse(txtHeightIn.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out heightIn))
                {
                    MessageBox.Show("Invalid inches format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtWeight.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double weight))
                {
                    MessageBox.Show("Invalid weight format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtBirthYear.Text, out int birthYear))
                {
                    MessageBox.Show("Invalid birth year format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert height to cm
                double heightCm;
                if (rdoMetric.Checked)
                {
                    heightCm = heightFt; // heightFt is actually cm
                }
                else
                {
                    double totalHeightInches = (heightFt * 12) + heightIn;
                    heightCm = totalHeightInches * 2.54; // inches to cm
                }

                // Convert weight to kg
                double weightKg = rdoMetric.Checked ? weight : weight * 0.453592;

                // Determine gender
                Gender gender = rdoMale.Checked ? Gender.Male : Gender.Female;

                // Determine activity level
                ActivityLevel activityLevel;
                switch (cmbActivityLevel.SelectedItem.ToString())
                {
                    case "Low":
                        activityLevel = ActivityLevel.Low;
                        break;
                    case "Medium":
                        activityLevel = ActivityLevel.Medium;
                        break;
                    case "High":
                        activityLevel = ActivityLevel.High;
                        break;
                    default:
                        MessageBox.Show("Invalid activity level.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Create Person object
                person = new Person(heightCm, weightKg, birthYear, gender, activityLevel);
                WaterIntakeCalculator calculator = new WaterIntakeCalculator(person);

                double dailyWaterMl = calculator.CalculateDailyWaterIntakeMl();
                double dailyWaterOunces = calculator.GetWaterIntakeInOunces();
                int dailyWaterGlasses = calculator.GetWaterIntakeInGlasses();

                // Calculate ounces per glass
                double ouncesPerGlass = dailyWaterGlasses > 0 ? dailyWaterOunces / dailyWaterGlasses : 0;

                // Update labels and GroupBox title, including person's name
                string personName = string.IsNullOrWhiteSpace(txtName.Text) ? "User" : txtName.Text;
                grpRecommendedWater.Text = $"Recommended Daily Water Consumption for {personName}";
                lblDailyWaterIntake.Text = $"Daily Water Intake";
                lblWaterIntakeOunces.Text = $"{dailyWaterOunces:F1} ounces";
                lblWaterIntakeGlasses.Text = $"{dailyWaterGlasses} glasses ({ouncesPerGlass:F2} oz)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Click Event for Retirement Savings Calculation
        private void btnCalculateRetirement_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cmbRetiringAge.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtCurrentSavings.Text) ||
                    string.IsNullOrWhiteSpace(txtMonthlySavings.Text) ||
                    string.IsNullOrWhiteSpace(txtAnnualInterest.Text) ||
                    string.IsNullOrWhiteSpace(txtBirthYear.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse inputs using TryParse
                if (!int.TryParse(cmbRetiringAge.SelectedItem.ToString(), out int retiringAge))
                {
                    MessageBox.Show("Invalid retiring age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtCurrentSavings.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double currentSavings))
                {
                    MessageBox.Show("Invalid current savings format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtMonthlySavings.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double monthlySavings))
                {
                    MessageBox.Show("Invalid monthly savings format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtAnnualInterest.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double annualInterestRate))
                {
                    MessageBox.Show("Invalid annual interest rate format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtBirthYear.Text, out int birthYear))
                {
                    MessageBox.Show("Invalid birth year format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                annualInterestRate /= 100; // Convert to decimal
                int currentYear = DateTime.Now.Year;
                int currentAge = currentYear - birthYear;
                int yearsToRetirement = retiringAge - currentAge;

                if (yearsToRetirement <= 0)
                {
                    MessageBox.Show("Retirement age must be greater than current age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create Person object (minimal for retirement, as height/weight/gender/activity not needed)
                person = new Person(0, 0, birthYear, Gender.Other, ActivityLevel.Low);
                RetirementSavingCalculator calculator = new RetirementSavingCalculator(person, currentSavings, monthlySavings, annualInterestRate, retiringAge);

                double totalFutureAmount = calculator.CalculateFutureSavings();
                double totalInterest = calculator.CalculateTotalInterest();
                double totalInvestment = currentSavings + (monthlySavings * 12 * yearsToRetirement);
                double growthPercentage = (totalInterest / totalInvestment) * 100;

                lblYearsToRetirement.Text = $"{yearsToRetirement} years";
                lblTotalFutureAmount.Text = totalFutureAmount.ToString("F2");
                lblTotalInterest.Text = totalInterest.ToString("F2");
                lblTotalInvestment.Text = totalInvestment.ToString("F2");
                lblGrowthPercentage.Text = $"{growthPercentage:F1}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e) { }

        private void label12_Click(object sender, EventArgs e) { }

        private void grpRecommendedWater_Enter(object sender, EventArgs e) { }

        private void txtName_TextChanged(object sender, EventArgs e) { }
    }
}