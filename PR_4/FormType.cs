using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PR_4
{
    public partial class FormType : Form
    {
        private TestDbContext db;

        public FormType()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new TestDbContext();
            this.db.Partners.Load();
            this.dataGridViewTypes.DataSource = this.db.Partners.Local.OrderBy(o => o.Name).ToList();

            // Сокрытие некоторых столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["IdPartner"].Visible = false;
            dataGridViewTypes.Columns["Rating"].Visible = false;
            dataGridViewTypes.Columns["IdPartnerNavigation"].Visible = false;
            dataGridViewTypes.Columns["PartnersProducts"].Visible = false;
            //dataGridViewTypes.Columns["Email"].Visible = false;
        }

        private void dataGridViewTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormTypesAdd formTypesAdd = new FormTypesAdd();
            DialogResult result = formTypesAdd.ShowDialog(this);

            Partner partner = new Partner();

            partner.Name = formTypesAdd.textBoxTypeName.Text;
            partner.LegalAddress = formTypesAdd.textBoxLegalAddress.Text;
            partner.Inn = formTypesAdd.textBoxINN.Text;
            partner.NameOfDirector = formTypesAdd.textBoxDirectorName.Text;
            partner.TelephoneNumber = formTypesAdd.textBoxTelephone.Text;
            partner.Email = formTypesAdd.textBoxEmail.Text;


            db.Partners.Add(partner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.Partners.Local.OrderBy(o => o.Name).ToList();
        }
    }
}