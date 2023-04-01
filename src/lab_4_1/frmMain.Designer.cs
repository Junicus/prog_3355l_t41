namespace lab_4_1;

partial class frmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        mainTable = new TableLayoutPanel();
        statusStrip1 = new StatusStrip();
        lblCount = new ToolStripStatusLabel();
        lvClientes = new ListView();
        cName = new ColumnHeader();
        tableDataLeft = new TableLayoutPanel();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        cbPueblo = new ComboBox();
        tbAge = new TextBox();
        tbEmail = new TextBox();
        tbName = new TextBox();
        tableDataRight = new TableLayoutPanel();
        groupSex = new GroupBox();
        flowSex = new FlowLayoutPanel();
        rbMale = new RadioButton();
        rbFemale = new RadioButton();
        flowActions = new FlowLayoutPanel();
        btnNew = new Button();
        btnAdd = new Button();
        btnDelete = new Button();
        cGenero = new ColumnHeader();
        cEdad = new ColumnHeader();
        cPueblo = new ColumnHeader();
        cEmail = new ColumnHeader();
        mainTable.SuspendLayout();
        statusStrip1.SuspendLayout();
        tableDataLeft.SuspendLayout();
        tableDataRight.SuspendLayout();
        groupSex.SuspendLayout();
        flowSex.SuspendLayout();
        flowActions.SuspendLayout();
        SuspendLayout();
        // 
        // mainTable
        // 
        mainTable.AutoSize = true;
        mainTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        mainTable.ColumnCount = 2;
        mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        mainTable.Controls.Add(statusStrip1, 0, 2);
        mainTable.Controls.Add(lvClientes, 0, 1);
        mainTable.Controls.Add(tableDataLeft, 0, 0);
        mainTable.Controls.Add(tableDataRight, 1, 0);
        mainTable.Dock = DockStyle.Fill;
        mainTable.Location = new Point(0, 0);
        mainTable.Name = "mainTable";
        mainTable.RowCount = 3;
        mainTable.RowStyles.Add(new RowStyle());
        mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainTable.RowStyles.Add(new RowStyle());
        mainTable.Size = new Size(734, 361);
        mainTable.TabIndex = 0;
        // 
        // statusStrip1
        // 
        mainTable.SetColumnSpan(statusStrip1, 2);
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblCount });
        statusStrip1.Location = new Point(0, 339);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(734, 22);
        statusStrip1.TabIndex = 0;
        statusStrip1.Text = "statusStrip1";
        // 
        // lblCount
        // 
        lblCount.Name = "lblCount";
        lblCount.Size = new Size(0, 17);
        // 
        // lvClientes
        // 
        lvClientes.Columns.AddRange(new ColumnHeader[] { cName, cGenero, cEdad, cPueblo, cEmail });
        mainTable.SetColumnSpan(lvClientes, 2);
        lvClientes.Dock = DockStyle.Fill;
        lvClientes.FullRowSelect = true;
        lvClientes.GridLines = true;
        lvClientes.Location = new Point(3, 125);
        lvClientes.MultiSelect = false;
        lvClientes.Name = "lvClientes";
        lvClientes.ShowGroups = false;
        lvClientes.Size = new Size(728, 211);
        lvClientes.TabIndex = 9;
        lvClientes.UseCompatibleStateImageBehavior = false;
        lvClientes.View = View.Details;
        // 
        // cName
        // 
        cName.Text = "Name";
        cName.Width = 150;
        // 
        // tableDataLeft
        // 
        tableDataLeft.AutoSize = true;
        tableDataLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableDataLeft.ColumnCount = 2;
        tableDataLeft.ColumnStyles.Add(new ColumnStyle());
        tableDataLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableDataLeft.Controls.Add(label1, 0, 0);
        tableDataLeft.Controls.Add(label2, 0, 1);
        tableDataLeft.Controls.Add(label3, 0, 2);
        tableDataLeft.Controls.Add(label4, 0, 3);
        tableDataLeft.Controls.Add(cbPueblo, 1, 3);
        tableDataLeft.Controls.Add(tbAge, 1, 2);
        tableDataLeft.Controls.Add(tbEmail, 1, 1);
        tableDataLeft.Controls.Add(tbName, 1, 0);
        tableDataLeft.Dock = DockStyle.Fill;
        tableDataLeft.Location = new Point(3, 3);
        tableDataLeft.Name = "tableDataLeft";
        tableDataLeft.RowCount = 4;
        tableDataLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableDataLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableDataLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableDataLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableDataLeft.Size = new Size(361, 116);
        tableDataLeft.TabIndex = 2;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(3, 7);
        label1.Name = "label1";
        label1.Size = new Size(54, 15);
        label1.TabIndex = 0;
        label1.Text = "Nombre:";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(3, 36);
        label2.Name = "label2";
        label2.Size = new Size(54, 15);
        label2.TabIndex = 1;
        label2.Text = "Email:";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(3, 65);
        label3.Name = "label3";
        label3.Size = new Size(54, 15);
        label3.TabIndex = 2;
        label3.Text = "Age:";
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(3, 94);
        label4.Name = "label4";
        label4.Size = new Size(54, 15);
        label4.TabIndex = 3;
        label4.Text = "Pueblo:";
        // 
        // cbPueblo
        // 
        cbPueblo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cbPueblo.FormattingEnabled = true;
        cbPueblo.Location = new Point(63, 90);
        cbPueblo.Name = "cbPueblo";
        cbPueblo.Size = new Size(295, 23);
        cbPueblo.TabIndex = 3;
        // 
        // tbAge
        // 
        tbAge.Anchor = AnchorStyles.Left;
        tbAge.Location = new Point(63, 61);
        tbAge.Name = "tbAge";
        tbAge.Size = new Size(100, 23);
        tbAge.TabIndex = 2;
        // 
        // tbEmail
        // 
        tbEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbEmail.Location = new Point(63, 32);
        tbEmail.Name = "tbEmail";
        tbEmail.Size = new Size(295, 23);
        tbEmail.TabIndex = 1;
        // 
        // tbName
        // 
        tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbName.Location = new Point(63, 3);
        tbName.Name = "tbName";
        tbName.Size = new Size(295, 23);
        tbName.TabIndex = 0;
        // 
        // tableDataRight
        // 
        tableDataRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableDataRight.ColumnCount = 1;
        tableDataRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableDataRight.Controls.Add(groupSex, 0, 0);
        tableDataRight.Controls.Add(flowActions, 0, 1);
        tableDataRight.Dock = DockStyle.Fill;
        tableDataRight.Location = new Point(370, 3);
        tableDataRight.Name = "tableDataRight";
        tableDataRight.RowCount = 2;
        tableDataRight.RowStyles.Add(new RowStyle());
        tableDataRight.RowStyles.Add(new RowStyle());
        tableDataRight.Size = new Size(361, 116);
        tableDataRight.TabIndex = 3;
        // 
        // groupSex
        // 
        groupSex.Anchor = AnchorStyles.None;
        groupSex.AutoSize = true;
        groupSex.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        groupSex.Controls.Add(flowSex);
        groupSex.Location = new Point(93, 3);
        groupSex.Name = "groupSex";
        groupSex.Padding = new Padding(5);
        groupSex.Size = new Size(175, 55);
        groupSex.TabIndex = 1;
        groupSex.TabStop = false;
        // 
        // flowSex
        // 
        flowSex.AutoSize = true;
        flowSex.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowSex.Controls.Add(rbMale);
        flowSex.Controls.Add(rbFemale);
        flowSex.Dock = DockStyle.Fill;
        flowSex.Location = new Point(5, 21);
        flowSex.Name = "flowSex";
        flowSex.Size = new Size(165, 29);
        flowSex.TabIndex = 0;
        // 
        // rbMale
        // 
        rbMale.AutoSize = true;
        rbMale.Location = new Point(10, 5);
        rbMale.Margin = new Padding(10, 5, 10, 5);
        rbMale.Name = "rbMale";
        rbMale.Size = new Size(69, 19);
        rbMale.TabIndex = 4;
        rbMale.TabStop = true;
        rbMale.Text = "Hombre";
        rbMale.UseVisualStyleBackColor = true;
        // 
        // rbFemale
        // 
        rbFemale.AutoSize = true;
        rbFemale.Location = new Point(99, 5);
        rbFemale.Margin = new Padding(10, 5, 10, 5);
        rbFemale.Name = "rbFemale";
        rbFemale.Size = new Size(56, 19);
        rbFemale.TabIndex = 5;
        rbFemale.TabStop = true;
        rbFemale.Text = "Mujer";
        rbFemale.UseVisualStyleBackColor = true;
        // 
        // flowActions
        // 
        flowActions.Anchor = AnchorStyles.None;
        flowActions.AutoSize = true;
        flowActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowActions.Controls.Add(btnNew);
        flowActions.Controls.Add(btnAdd);
        flowActions.Controls.Add(btnDelete);
        flowActions.Location = new Point(53, 66);
        flowActions.Margin = new Padding(0);
        flowActions.Name = "flowActions";
        flowActions.Size = new Size(255, 45);
        flowActions.TabIndex = 0;
        // 
        // btnNew
        // 
        btnNew.AutoSize = true;
        btnNew.Location = new Point(5, 5);
        btnNew.Margin = new Padding(5);
        btnNew.Name = "btnNew";
        btnNew.Padding = new Padding(5);
        btnNew.Size = new Size(75, 35);
        btnNew.TabIndex = 6;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = true;
        btnNew.Click += btnNew_Click;
        // 
        // btnAdd
        // 
        btnAdd.AutoSize = true;
        btnAdd.Location = new Point(90, 5);
        btnAdd.Margin = new Padding(5);
        btnAdd.Name = "btnAdd";
        btnAdd.Padding = new Padding(5);
        btnAdd.Size = new Size(75, 35);
        btnAdd.TabIndex = 7;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.AutoSize = true;
        btnDelete.Location = new Point(175, 5);
        btnDelete.Margin = new Padding(5);
        btnDelete.Name = "btnDelete";
        btnDelete.Padding = new Padding(5);
        btnDelete.Size = new Size(75, 35);
        btnDelete.TabIndex = 8;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // cGenero
        // 
        cGenero.Text = "Genero";
        // 
        // cEdad
        // 
        cEdad.Text = "Edad";
        // 
        // cPueblo
        // 
        cPueblo.Text = "Pueblo";
        cPueblo.Width = 150;
        // 
        // cEmail
        // 
        cEmail.Text = "Email";
        cEmail.Width = 200;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(734, 361);
        Controls.Add(mainTable);
        MinimumSize = new Size(750, 400);
        Name = "frmMain";
        Text = "Registro de Clientes";
        Load += frmMain_Load;
        mainTable.ResumeLayout(false);
        mainTable.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        tableDataLeft.ResumeLayout(false);
        tableDataLeft.PerformLayout();
        tableDataRight.ResumeLayout(false);
        tableDataRight.PerformLayout();
        groupSex.ResumeLayout(false);
        groupSex.PerformLayout();
        flowSex.ResumeLayout(false);
        flowSex.PerformLayout();
        flowActions.ResumeLayout(false);
        flowActions.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel mainTable;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblCount;
    private ListView lvClientes;
    private TableLayoutPanel tableDataLeft;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private ComboBox cbPueblo;
    private TextBox tbAge;
    private TextBox tbEmail;
    private TextBox tbName;
    private TableLayoutPanel tableDataRight;
    private FlowLayoutPanel flowActions;
    private Button btnNew;
    private Button btnAdd;
    private Button btnDelete;
    private GroupBox groupSex;
    private FlowLayoutPanel flowSex;
    private RadioButton rbMale;
    private RadioButton rbFemale;
    private ColumnHeader cName;
    private ColumnHeader cGenero;
    private ColumnHeader cEdad;
    private ColumnHeader cPueblo;
    private ColumnHeader cEmail;
}
