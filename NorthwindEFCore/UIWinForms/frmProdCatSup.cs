﻿namespace UIWinForms;
public partial class frmProdCatSup : Form
{
	private readonly NorthwindContext context;
	private readonly DalVwProdCatSup dalVwProdCatSup;
	public frmProdCatSup()
	{
		InitializeComponent();
		dalVwProdCatSup = new(context = new());

	}

	private void frmProdCatSup_Load(object sender, EventArgs e)
	{
		dgwProdCatSup.DataSource = dalVwProdCatSup.GetAll().ToList();
		dgwProdCatSup.AutoResizeRows();
	}
}