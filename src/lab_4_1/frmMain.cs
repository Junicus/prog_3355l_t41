namespace lab_4_1;

public partial class frmMain : Form
{
    private readonly List<string> _pueblos = new List<string>();

    public frmMain()
    {
        _pueblos.AddRange(new[] { "San Juan", "Carolina", "Bayamon", "Ponce", "Caguas", "Humacao", "Luquillo" });

        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        cbPueblo.DataSource = _pueblos;
        cbPueblo.SelectedIndex = -1;

        lblCount.Text = $"{lvClientes.Items.Count} Items";
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        tbName.Text = string.Empty;
        tbEmail.Text = string.Empty;
        tbAge.Text = string.Empty;
        cbPueblo.SelectedIndex = -1;
        rbMale.Checked = false;
        rbFemale.Checked = false;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (
            string.IsNullOrEmpty(tbName.Text.Trim()) ||
            string.IsNullOrEmpty(tbEmail.Text.Trim()) ||
            string.IsNullOrEmpty(tbAge.Text.Trim()) ||
            cbPueblo.SelectedIndex < 0 ||
            (!rbMale.Checked && !rbFemale.Checked))
        {
            MessageBox.Show("Todos los cambos deben estar llenos o seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (int.TryParse(tbAge.Text.Trim(), out var age) && (age < 20 || age >80))
        {
            MessageBox.Show("La edad debe ser entry 20 y 80 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lvClientes.Items.Add(new ListViewItem(new[]
        {
            tbName.Text.Trim(),
            rbMale.Checked ? "H" : "M",
            tbAge.Text.Trim(),
            cbPueblo.SelectedItem.ToString(),
            tbEmail.Text.Trim()
        }));

        lblCount.Text = $"{lvClientes.Items.Count} Items";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (lvClientes.Items.Count == 0)
        {
            MessageBox.Show("No hay clientes en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (lvClientes.SelectedIndices.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un cliente de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lvClientes.Items.RemoveAt(lvClientes.SelectedIndices[0]);

        lblCount.Text = $"{lvClientes.Items.Count} Items";
    }
}