namespace Projeto_V1
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.panelLeftModal = new System.Windows.Forms.Panel();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btAgendaAgendamento = new System.Windows.Forms.Button();
            this.btAgendaConsulta = new System.Windows.Forms.Button();
            this.panelDropDown2 = new System.Windows.Forms.Panel();
            this.btFuncionarioDeletar = new System.Windows.Forms.Button();
            this.btFuncionarioEditar = new System.Windows.Forms.Button();
            this.btFuncionarioCadastrar = new System.Windows.Forms.Button();
            this.btFuncionarioConsulta = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.panelDropDown3 = new System.Windows.Forms.Panel();
            this.btClienteDeletar = new System.Windows.Forms.Button();
            this.btClienteEditar = new System.Windows.Forms.Button();
            this.btClienteCadastrar = new System.Windows.Forms.Button();
            this.btClienteConsulta = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.panelDropDown4 = new System.Windows.Forms.Panel();
            this.btServicoDeletar = new System.Windows.Forms.Button();
            this.btServicoEditar = new System.Windows.Forms.Button();
            this.btServicoCriar = new System.Windows.Forms.Button();
            this.btServicoConsulta = new System.Windows.Forms.Button();
            this.btServicos = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.relogioGif = new System.Windows.Forms.PictureBox();
            this.panelLeftTop.SuspendLayout();
            this.panelLeftModal.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.panelDropDown2.SuspendLayout();
            this.panelDropDown3.SuspendLayout();
            this.panelDropDown4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relogioGif)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelTop.Location = new System.Drawing.Point(202, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1149, 69);
            this.PanelTop.TabIndex = 0;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BackColor = System.Drawing.Color.Cyan;
            this.panelLeftTop.Controls.Add(this.hora);
            this.panelLeftTop.Controls.Add(this.data);
            this.panelLeftTop.Controls.Add(this.relogioGif);
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(202, 69);
            this.panelLeftTop.TabIndex = 1;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(70, 35);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(57, 22);
            this.hora.TabIndex = 3;
            this.hora.Text = "Hora";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(70, 13);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(55, 22);
            this.data.TabIndex = 3;
            this.data.Text = "Data";
            // 
            // panelLeftModal
            // 
            this.panelLeftModal.BackColor = System.Drawing.Color.Silver;
            this.panelLeftModal.Controls.Add(this.panelDropDown);
            this.panelLeftModal.Controls.Add(this.panelDropDown2);
            this.panelLeftModal.Controls.Add(this.panelDropDown3);
            this.panelLeftModal.Controls.Add(this.panelDropDown4);
            this.panelLeftModal.Location = new System.Drawing.Point(0, 69);
            this.panelLeftModal.Name = "panelLeftModal";
            this.panelLeftModal.Size = new System.Drawing.Size(202, 659);
            this.panelLeftModal.TabIndex = 2;
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown.Controls.Add(this.btAgendaAgendamento);
            this.panelDropDown.Controls.Add(this.btAgendaConsulta);
            this.panelDropDown.Controls.Add(this.btAgenda);
            this.panelDropDown.Location = new System.Drawing.Point(6, 7);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(190, 144);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(190, 60);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(190, 60);
            this.panelDropDown.TabIndex = 11;
            // 
            // btAgendaAgendamento
            // 
            this.btAgendaAgendamento.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btAgendaAgendamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAgendaAgendamento.FlatAppearance.BorderSize = 0;
            this.btAgendaAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgendaAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgendaAgendamento.Location = new System.Drawing.Point(0, 103);
            this.btAgendaAgendamento.Name = "btAgendaAgendamento";
            this.btAgendaAgendamento.Size = new System.Drawing.Size(190, 41);
            this.btAgendaAgendamento.TabIndex = 2;
            this.btAgendaAgendamento.Text = "Agendamento";
            this.btAgendaAgendamento.UseVisualStyleBackColor = false;
            // 
            // btAgendaConsulta
            // 
            this.btAgendaConsulta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btAgendaConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAgendaConsulta.FlatAppearance.BorderSize = 0;
            this.btAgendaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgendaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgendaConsulta.Location = new System.Drawing.Point(0, 62);
            this.btAgendaConsulta.Name = "btAgendaConsulta";
            this.btAgendaConsulta.Size = new System.Drawing.Size(190, 41);
            this.btAgendaConsulta.TabIndex = 1;
            this.btAgendaConsulta.Text = "Consulta";
            this.btAgendaConsulta.UseVisualStyleBackColor = false;
            // 
            // panelDropDown2
            // 
            this.panelDropDown2.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown2.Controls.Add(this.btFuncionarioDeletar);
            this.panelDropDown2.Controls.Add(this.btFuncionarioEditar);
            this.panelDropDown2.Controls.Add(this.btFuncionarioCadastrar);
            this.panelDropDown2.Controls.Add(this.btFuncionarioConsulta);
            this.panelDropDown2.Controls.Add(this.btFuncionario);
            this.panelDropDown2.Location = new System.Drawing.Point(6, 85);
            this.panelDropDown2.MaximumSize = new System.Drawing.Size(190, 227);
            this.panelDropDown2.MinimumSize = new System.Drawing.Size(190, 60);
            this.panelDropDown2.Name = "panelDropDown2";
            this.panelDropDown2.Size = new System.Drawing.Size(190, 60);
            this.panelDropDown2.TabIndex = 12;
            // 
            // btFuncionarioDeletar
            // 
            this.btFuncionarioDeletar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btFuncionarioDeletar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionarioDeletar.FlatAppearance.BorderSize = 0;
            this.btFuncionarioDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionarioDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionarioDeletar.Location = new System.Drawing.Point(0, 185);
            this.btFuncionarioDeletar.Name = "btFuncionarioDeletar";
            this.btFuncionarioDeletar.Size = new System.Drawing.Size(190, 42);
            this.btFuncionarioDeletar.TabIndex = 4;
            this.btFuncionarioDeletar.Text = "Deletar";
            this.btFuncionarioDeletar.UseVisualStyleBackColor = false;
            // 
            // btFuncionarioEditar
            // 
            this.btFuncionarioEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btFuncionarioEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionarioEditar.FlatAppearance.BorderSize = 0;
            this.btFuncionarioEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionarioEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionarioEditar.Location = new System.Drawing.Point(0, 144);
            this.btFuncionarioEditar.Name = "btFuncionarioEditar";
            this.btFuncionarioEditar.Size = new System.Drawing.Size(190, 41);
            this.btFuncionarioEditar.TabIndex = 3;
            this.btFuncionarioEditar.Text = "Editar";
            this.btFuncionarioEditar.UseVisualStyleBackColor = false;
            // 
            // btFuncionarioCadastrar
            // 
            this.btFuncionarioCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btFuncionarioCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionarioCadastrar.FlatAppearance.BorderSize = 0;
            this.btFuncionarioCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionarioCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionarioCadastrar.Location = new System.Drawing.Point(0, 103);
            this.btFuncionarioCadastrar.Name = "btFuncionarioCadastrar";
            this.btFuncionarioCadastrar.Size = new System.Drawing.Size(190, 41);
            this.btFuncionarioCadastrar.TabIndex = 2;
            this.btFuncionarioCadastrar.Text = "Cadastrar";
            this.btFuncionarioCadastrar.UseVisualStyleBackColor = false;
            // 
            // btFuncionarioConsulta
            // 
            this.btFuncionarioConsulta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btFuncionarioConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionarioConsulta.FlatAppearance.BorderSize = 0;
            this.btFuncionarioConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionarioConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionarioConsulta.Location = new System.Drawing.Point(0, 62);
            this.btFuncionarioConsulta.Name = "btFuncionarioConsulta";
            this.btFuncionarioConsulta.Size = new System.Drawing.Size(190, 41);
            this.btFuncionarioConsulta.TabIndex = 1;
            this.btFuncionarioConsulta.Text = "Consulta";
            this.btFuncionarioConsulta.UseVisualStyleBackColor = false;
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.Turquoise;
            this.btFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionario.FlatAppearance.BorderSize = 0;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionario.Image = global::Projeto_V1.Properties.Resources.Expand_Arrow_20px;
            this.btFuncionario.Location = new System.Drawing.Point(0, 0);
            this.btFuncionario.MaximumSize = new System.Drawing.Size(190, 227);
            this.btFuncionario.MinimumSize = new System.Drawing.Size(190, 60);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(190, 62);
            this.btFuncionario.TabIndex = 0;
            this.btFuncionario.Text = "Funcionários";
            this.btFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btFuncionario.UseVisualStyleBackColor = false;
            // 
            // panelDropDown3
            // 
            this.panelDropDown3.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown3.Controls.Add(this.btClienteDeletar);
            this.panelDropDown3.Controls.Add(this.btClienteEditar);
            this.panelDropDown3.Controls.Add(this.btClienteCadastrar);
            this.panelDropDown3.Controls.Add(this.btClienteConsulta);
            this.panelDropDown3.Controls.Add(this.btCliente);
            this.panelDropDown3.Location = new System.Drawing.Point(6, 163);
            this.panelDropDown3.MaximumSize = new System.Drawing.Size(190, 227);
            this.panelDropDown3.MinimumSize = new System.Drawing.Size(190, 60);
            this.panelDropDown3.Name = "panelDropDown3";
            this.panelDropDown3.Size = new System.Drawing.Size(190, 60);
            this.panelDropDown3.TabIndex = 13;
            // 
            // btClienteDeletar
            // 
            this.btClienteDeletar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btClienteDeletar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClienteDeletar.FlatAppearance.BorderSize = 0;
            this.btClienteDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClienteDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClienteDeletar.Location = new System.Drawing.Point(0, 185);
            this.btClienteDeletar.Name = "btClienteDeletar";
            this.btClienteDeletar.Size = new System.Drawing.Size(190, 42);
            this.btClienteDeletar.TabIndex = 4;
            this.btClienteDeletar.Text = "Deletar";
            this.btClienteDeletar.UseVisualStyleBackColor = false;
            // 
            // btClienteEditar
            // 
            this.btClienteEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btClienteEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClienteEditar.FlatAppearance.BorderSize = 0;
            this.btClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClienteEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClienteEditar.Location = new System.Drawing.Point(0, 144);
            this.btClienteEditar.Name = "btClienteEditar";
            this.btClienteEditar.Size = new System.Drawing.Size(190, 41);
            this.btClienteEditar.TabIndex = 3;
            this.btClienteEditar.Text = "Editar";
            this.btClienteEditar.UseVisualStyleBackColor = false;
            // 
            // btClienteCadastrar
            // 
            this.btClienteCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btClienteCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClienteCadastrar.FlatAppearance.BorderSize = 0;
            this.btClienteCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClienteCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClienteCadastrar.Location = new System.Drawing.Point(0, 103);
            this.btClienteCadastrar.Name = "btClienteCadastrar";
            this.btClienteCadastrar.Size = new System.Drawing.Size(190, 41);
            this.btClienteCadastrar.TabIndex = 2;
            this.btClienteCadastrar.Text = "Cadastrar";
            this.btClienteCadastrar.UseVisualStyleBackColor = false;
            // 
            // btClienteConsulta
            // 
            this.btClienteConsulta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btClienteConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClienteConsulta.FlatAppearance.BorderSize = 0;
            this.btClienteConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClienteConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClienteConsulta.Location = new System.Drawing.Point(0, 62);
            this.btClienteConsulta.Name = "btClienteConsulta";
            this.btClienteConsulta.Size = new System.Drawing.Size(190, 41);
            this.btClienteConsulta.TabIndex = 1;
            this.btClienteConsulta.Text = "Consulta";
            this.btClienteConsulta.UseVisualStyleBackColor = false;
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.Turquoise;
            this.btCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.Image = global::Projeto_V1.Properties.Resources.Expand_Arrow_20px;
            this.btCliente.Location = new System.Drawing.Point(0, 0);
            this.btCliente.MaximumSize = new System.Drawing.Size(190, 227);
            this.btCliente.MinimumSize = new System.Drawing.Size(190, 60);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(190, 62);
            this.btCliente.TabIndex = 0;
            this.btCliente.Text = "Clientes";
            this.btCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btCliente.UseVisualStyleBackColor = false;
            // 
            // panelDropDown4
            // 
            this.panelDropDown4.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown4.Controls.Add(this.btServicoDeletar);
            this.panelDropDown4.Controls.Add(this.btServicoEditar);
            this.panelDropDown4.Controls.Add(this.btServicoCriar);
            this.panelDropDown4.Controls.Add(this.btServicoConsulta);
            this.panelDropDown4.Controls.Add(this.btServicos);
            this.panelDropDown4.Location = new System.Drawing.Point(6, 241);
            this.panelDropDown4.MaximumSize = new System.Drawing.Size(190, 227);
            this.panelDropDown4.MinimumSize = new System.Drawing.Size(190, 60);
            this.panelDropDown4.Name = "panelDropDown4";
            this.panelDropDown4.Size = new System.Drawing.Size(190, 60);
            this.panelDropDown4.TabIndex = 14;
            // 
            // btServicoDeletar
            // 
            this.btServicoDeletar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btServicoDeletar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServicoDeletar.FlatAppearance.BorderSize = 0;
            this.btServicoDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServicoDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServicoDeletar.Location = new System.Drawing.Point(0, 185);
            this.btServicoDeletar.Name = "btServicoDeletar";
            this.btServicoDeletar.Size = new System.Drawing.Size(190, 42);
            this.btServicoDeletar.TabIndex = 4;
            this.btServicoDeletar.Text = "Deletar";
            this.btServicoDeletar.UseVisualStyleBackColor = false;
            // 
            // btServicoEditar
            // 
            this.btServicoEditar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btServicoEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServicoEditar.FlatAppearance.BorderSize = 0;
            this.btServicoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServicoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServicoEditar.Location = new System.Drawing.Point(0, 144);
            this.btServicoEditar.Name = "btServicoEditar";
            this.btServicoEditar.Size = new System.Drawing.Size(190, 41);
            this.btServicoEditar.TabIndex = 3;
            this.btServicoEditar.Text = "Editar";
            this.btServicoEditar.UseVisualStyleBackColor = false;
            // 
            // btServicoCriar
            // 
            this.btServicoCriar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btServicoCriar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServicoCriar.FlatAppearance.BorderSize = 0;
            this.btServicoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServicoCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServicoCriar.Location = new System.Drawing.Point(0, 103);
            this.btServicoCriar.Name = "btServicoCriar";
            this.btServicoCriar.Size = new System.Drawing.Size(190, 41);
            this.btServicoCriar.TabIndex = 2;
            this.btServicoCriar.Text = "Criar";
            this.btServicoCriar.UseVisualStyleBackColor = false;
            // 
            // btServicoConsulta
            // 
            this.btServicoConsulta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btServicoConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServicoConsulta.FlatAppearance.BorderSize = 0;
            this.btServicoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServicoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServicoConsulta.Location = new System.Drawing.Point(0, 62);
            this.btServicoConsulta.Name = "btServicoConsulta";
            this.btServicoConsulta.Size = new System.Drawing.Size(190, 41);
            this.btServicoConsulta.TabIndex = 1;
            this.btServicoConsulta.Text = "Consulta";
            this.btServicoConsulta.UseVisualStyleBackColor = false;
            // 
            // btServicos
            // 
            this.btServicos.BackColor = System.Drawing.Color.Turquoise;
            this.btServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btServicos.FlatAppearance.BorderSize = 0;
            this.btServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServicos.Image = global::Projeto_V1.Properties.Resources.Expand_Arrow_20px;
            this.btServicos.Location = new System.Drawing.Point(0, 0);
            this.btServicos.MaximumSize = new System.Drawing.Size(190, 227);
            this.btServicos.MinimumSize = new System.Drawing.Size(190, 60);
            this.btServicos.Name = "btServicos";
            this.btServicos.Size = new System.Drawing.Size(190, 62);
            this.btServicos.TabIndex = 0;
            this.btServicos.Text = "Serviços";
            this.btServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btServicos.UseVisualStyleBackColor = false;
            // 
            // btAgenda
            // 
            this.btAgenda.BackColor = System.Drawing.Color.Turquoise;
            this.btAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAgenda.FlatAppearance.BorderSize = 0;
            this.btAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgenda.Image = global::Projeto_V1.Properties.Resources.Expand_Arrow_20px;
            this.btAgenda.Location = new System.Drawing.Point(0, 0);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(190, 62);
            this.btAgenda.TabIndex = 0;
            this.btAgenda.Text = "Agenda";
            this.btAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btAgenda.UseVisualStyleBackColor = false;
            // 
            // relogioGif
            // 
            this.relogioGif.BackgroundImage = global::Projeto_V1.Properties.Resources.relogio;
            this.relogioGif.Image = global::Projeto_V1.Properties.Resources.relogio;
            this.relogioGif.Location = new System.Drawing.Point(11, 8);
            this.relogioGif.Name = "relogioGif";
            this.relogioGif.Size = new System.Drawing.Size(52, 54);
            this.relogioGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.relogioGif.TabIndex = 3;
            this.relogioGif.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelLeftModal);
            this.Controls.Add(this.panelLeftTop);
            this.Controls.Add(this.PanelTop);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Principal";
            this.Text = "Form1";
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.panelLeftModal.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown2.ResumeLayout(false);
            this.panelDropDown3.ResumeLayout(false);
            this.panelDropDown4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relogioGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelTop;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Panel panelLeftModal;
        private System.Windows.Forms.PictureBox relogioGif;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btAgendaAgendamento;
        private System.Windows.Forms.Button btAgendaConsulta;
        private System.Windows.Forms.Button btAgenda;
        private System.Windows.Forms.Panel panelDropDown2;
        private System.Windows.Forms.Button btFuncionarioDeletar;
        private System.Windows.Forms.Button btFuncionarioEditar;
        private System.Windows.Forms.Button btFuncionarioCadastrar;
        private System.Windows.Forms.Button btFuncionarioConsulta;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.Panel panelDropDown3;
        private System.Windows.Forms.Button btClienteDeletar;
        private System.Windows.Forms.Button btClienteEditar;
        private System.Windows.Forms.Button btClienteCadastrar;
        private System.Windows.Forms.Button btClienteConsulta;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Panel panelDropDown4;
        private System.Windows.Forms.Button btServicoDeletar;
        private System.Windows.Forms.Button btServicoEditar;
        private System.Windows.Forms.Button btServicoCriar;
        private System.Windows.Forms.Button btServicoConsulta;
        private System.Windows.Forms.Button btServicos;
    }
}

