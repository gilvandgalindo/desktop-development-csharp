using GerenciamentoFuncionario.AcessoDados;
using GerenciamentoFuncionario.ViewModel;

namespace GerenciamentoFuncionario.WinForms
{
    public partial class MainForm : Form
    {
        private readonly MainWindowViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel(new FuncionarioProvedorDados(), new CargoProvedorDados());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _viewModel.Carregar();
            funcionarioBindingSource.DataSource = _viewModel.Funcionarios;

            lsbFuncionarios.DataSource = _viewModel.Funcionarios;
            lsbFuncionarios.DisplayMember = "NomeCompleto";

            cmbCargos.DataSource = _viewModel.Cargos;
            cmbCargos.DisplayMember = "NomeCargo";
            cmbCargos.ValueMember = "Id";
            cmbCargos.DataBindings.Add("SelectedValue", funcionarioBindingSource, "CargoId");

            txtNomeCompleto.DataBindings.Add(
                "Text", 
                funcionarioBindingSource, 
                "NomeCompleto", 
                false, 
                DataSourceUpdateMode.OnPropertyChanged);

            dtpDataNascimento.DataBindings.Add(
                "Value",
                funcionarioBindingSource,
                "DataHoraEntrada"
                );

            chkEBebedorCafe.DataBindings.Add(
                "Checked",
                funcionarioBindingSource,
                "EBebedorCafe"
                );

            btnSalvar.DataBindings.Add("Enabled", funcionarioBindingSource, "PodeSalvar");
        }
    }
}