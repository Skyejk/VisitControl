using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitСontrol.Entities;

namespace VisitСontrol
{
    public partial class MainForm : Form
    {
        WorkingDay workingDay = new WorkingDay();
        public MainForm()
        {
            InitializeComponent();

            cmbxEmployee.DataSource = dbEntities.GetContext().Employee.ToList();
            cmbxEmployee.DisplayMember = "Surname"; cmbxEmployee.ValueMember = "ID";
            cmbxEmployee.Text = "";

            mainDataGridView.DataSource = dbEntities.GetContext().WorkingDay.ToList();
        }
        //сохранение
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                int employee = Convert.ToInt32(cmbxEmployee.SelectedValue);
                DateTime thisDay = dtpThisDay.Value;
                TimeSpan firstVisit = TimeSpan.Parse(tbxFirstVisit.Text);
                TimeSpan leftForLunch = TimeSpan.Parse(tbxLeftForLunch.Text);
                TimeSpan returnedFromLunch = TimeSpan.Parse(tbxReturnedFromLunch.Text);
                TimeSpan lastLeaving = TimeSpan.Parse(tbxLastLeaving.Text);


                workingDay.EmployeeID = employee;
                workingDay.ThisDay = thisDay;
                workingDay.FirstVisit = firstVisit;
                workingDay.LeftForLunch = leftForLunch;
                workingDay.ReturnedFromLunch = returnedFromLunch;
                workingDay.LastLeaving = lastLeaving;

                dbEntities.GetContext().WorkingDay.Add(workingDay);
                dbEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись добавлена!", "Успешно!");
                mainDataGridView.DataSource = dbEntities.GetContext().WorkingDay.ToList();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //очистка
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbxEmployee.Text = "";
            dtpThisDay.Value = DateTime.Today;
            tbxFirstVisit.Text = "";
            tbxLeftForLunch.Text = "";
            tbxReturnedFromLunch.Text = "";
            tbxLastLeaving.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение разработано студентом группы ПР-49, специально для МБУК Воровсколесского СДК",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly,
                false);
        }
    }
}
