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
            CarregarDados();
        }

        private void CarregarDados()
        {
            _viewModel.Carregar();

            funcionarioBindingSource.DataSource = _viewModel.Funcionarios;

            lsbFuncionarios.DataSource = funcionarioBindingSource;
            lsbFuncionarios.DisplayMember = "NomeCompleto";

            cmbCargos.DataSource = _viewModel.Cargos;
            cmbCargos.DisplayMember = "CargoNome";
            cmbCargos.ValueMember = "Id";

            var dataEstaoBindingsAtualizados = cmbCargos.DataBindings.Count > 0;
            if (dataEstaoBindingsAtualizados)
            {
                funcionarioBindingSource.ResetBindings(false);
            }
            else
            {
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcionarioBindingSource.Current is FuncionarioViewModel funcionarioViewModel
                && funcionarioViewModel.PodeSalvar)
            {
                funcionarioViewModel.Salvar();
            }
        }
    }
}