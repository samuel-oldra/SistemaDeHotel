PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [clientes] (
  [id] INTEGER NOT NULL PRIMARY KEY, 
  [flag] CHAR NOT NULL, 
  [update] DATETIME NOT NULL, 
  [cliente] TEXT NOT NULL, 
  [cpf] TEXT, 
  [rg] TEXT, 
  [nascimento] DATETIME, 
  [sexo] TEXT, 
  [profissao] TEXT, 
  [veiculo] TEXT, 
  [placa] TEXT, 
  [email] TEXT, 
  [fonecelular] TEXT, 
  [foneresidencial] TEXT, 
  [fonecomercial] TEXT, 
  [ramal] TEXT, 
  [endereco] TEXT, 
  [bairro] TEXT, 
  [cidade] TEXT, 
  [estado] TEXT, 
  [pais] TEXT, 
  [cep] TEXT, 
  [pontoref] TEXT, 
  [observacoes] TEXT);
CREATE TABLE [contas] (
  [id] INTEGER NOT NULL PRIMARY KEY, 
  [flag] CHAR NOT NULL, 
  [update] DATETIME NOT NULL, 
  [reserva_confirmada] CHAR, 
  [validade_reserva] DATETIME, 
  [entrada] DATETIME NOT NULL, 
  [saida] DATETIME NOT NULL, 
  [check_in] DATETIME, 
  [check_out] DATETIME, 
  [id_unidade_habitacional] INTEGER NOT NULL, 
  [id_cliente] INTEGER NOT NULL, 
  [valor] DOUBLE NOT NULL, 
  [observacoes] TEXT);
CREATE TABLE [tipos_unidades_habitacionais] (
  [id] INTEGER NOT NULL PRIMARY KEY, 
  [flag] CHAR NOT NULL, 
  [update] DATETIME NOT NULL, 
  [nome] TEXT NOT NULL, 
  [diaria] DOUBLE NOT NULL);
CREATE TABLE [unidades_habitacionais] (
  [id] INTEGER NOT NULL PRIMARY KEY, 
  [flag] CHAR NOT NULL, 
  [update] DATETIME NOT NULL, 
  [nome] TEXT NOT NULL, 
  [id_tipo_unidade_habitacional] INTEGER NOT NULL, 
  [situacao] TEXT NOT NULL, 
  [ramal] TEXT, 
  [caracteristicas] TEXT);
CREATE TABLE [usuarios] (
  [id] INTEGER NOT NULL PRIMARY KEY, 
  [usuario] TEXT NOT NULL, 
  [senha] TEXT NOT NULL);
INSERT INTO "usuarios" VALUES(1,'demo','demo');
CREATE INDEX [idx_flag_clientes] ON [clientes] ([flag]);
CREATE INDEX [idx_flag_contas] ON [contas] ([flag]);
CREATE INDEX [idx_flag_tipos_unidades_habitacionais] ON [tipos_unidades_habitacionais] ([flag]);
CREATE INDEX [idx_flag_unidades_habitacionais] ON [unidades_habitacionais] ([flag]);
COMMIT;
