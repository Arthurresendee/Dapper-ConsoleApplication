-- Procedimento
INSERT INTO [Procedimento] ([Titulo], [TipoDeProcedimento], [Descricao])
VALUES
    ('Clareamento dental', 5, 'Procedimento estético para clarear os dentes.'),
    ('Ortodontia', 6, 'Tratamento para correção de má oclusão e alinhamento dos dentes.'),
    ('Odontopediatria', 7, 'Atendimento odontológico especializado para crianças.'),
    ('Cirurgia de extração do siso', 8, 'Remoção dos dentes do siso impactados.'),
    ('Prótese dentária', 9, 'Reabilitação oral com próteses para substituir dentes ausentes.'),
    ('Periodontia', 0, 'Tratamento das estruturas de suporte dos dentes, como gengiva e osso alveolar.'),
    ('Endodontia', 1, 'Tratamento dos tecidos internos do dente, como a polpa.'),
    ('Odontologia estética', 2, 'Procedimentos para melhorar a estética do sorriso.'),
    ('Odontogeriatria', 3, 'Atendimento odontológico especializado para idosos.'),
    ('Odontologia preventiva', 4, 'Prevenção de doenças bucais e promoção da saúde oral.');

-- Plano
INSERT INTO [Plano] ([Titulo], [TipoDePlano], [Descricao], [Coberturas], [DataInicial], [DataFinal])
VALUES
    ('Plano Básico', 0, 'Plano básico de cobertura odontológica.', 'Consulta e limpeza', GETDATE(), DATEADD(YEAR, 1, GETDATE())),
    ('Plano Intermediário', 1, 'Plano intermediário de cobertura odontológica.', 'Consulta, limpeza, restauração', GETDATE(), DATEADD(YEAR, 1, GETDATE())),
    ('Plano Completo', 2, 'Plano completo de cobertura odontológica.', 'Consulta, limpeza, restauração, canal, prótese', GETDATE(), DATEADD(YEAR, 1, GETDATE())),
    ('Plano Premium', 3, 'Plano premium de cobertura odontológica.', 'Consulta, limpeza, restauração, canal, implante, ortodontia', GETDATE(), DATEADD(YEAR, 1, GETDATE())),
    ('Plano Familiar', 4, 'Plano de cobertura odontológica para toda a família.', 'Consulta, limpeza, restauração, canal, implante, ortodontia', GETDATE(), DATEADD(YEAR, 1, GETDATE()));



-- Endereco
INSERT INTO [Endereco] ([CEP], [Pais], [Estado], [Rua], [Numero])
VALUES
    ('12345-678', 'Brazil', 'São Paulo', 'Rua A', '123'),
    ('23456-789', 'Brazil', 'Rio de Janeiro', 'Rua B', '456'),
    ('34567-890', 'Brazil', 'Minas Gerais', 'Rua C', '789'),
    ('45678-901', 'Brazil', 'Bahia', 'Rua D', '1011'),
    ('56789-012', 'Brazil', 'Paraná', 'Rua E', '1213'),
    ('67890-123', 'Brazil', 'Santa Catarina', 'Rua F', '1415'),
    ('78901-234', 'Brazil', 'Rio Grande do Sul', 'Rua G', '1617'),
    ('89012-345', 'Brazil', 'Ceará', 'Rua H', '1819'),
    ('90123-456', 'Brazil', 'Pernambuco', 'Rua I', '2021'),
    ('01234-567', 'Brazil', 'Amazonas', 'Rua J', '2223'),
    ('12345-678', 'Brazil', 'São Paulo', 'Rua K', '2425'),
    ('23456-789', 'Brazil', 'Rio de Janeiro', 'Rua L', '2627'),
    ('34567-890', 'Brazil', 'Minas Gerais', 'Rua M', '2829'),
    ('45678-901', 'Brazil', 'Bahia', 'Rua N', '3031'),
    ('56789-012', 'Brazil', 'Paraná', 'Rua O', '3233');

	

-- Dentista
INSERT INTO [Dentista] ([Nome], [Sobrenome], [Idade], [CPF], [DataDeAniversario], [Email], [NumeroDeTelefone], [Especializacao], [NumeroDeRegistro], [IdEndereco])
VALUES
    ('João', 'Silva', 35, '12345678901', '15-05-1987', 'joao.silva@example.com', '(11) 98765-4321', 'Clínico Geral', 'CRM12345', 4),
    ('Maria', 'Santos', 40, '98765432109', '20-10-1982', 'maria.santos@example.com', '(21) 12345-6789', 'Ortodontista', 'CRM54321', 2),
    ('Pedro', 'Oliveira', 38, '45678901234', '12-08-1984', 'pedro.oliveira@example.com', '(31) 87654-3210', 'Periodontista', 'CRM67890', 5),
    ('Ana', 'Ferreira', 45, '23456789012', '25-03-1977', 'ana.ferreira@example.com', '(41) 54321-0987', 'Endodontista', 'CRM09876', 6),
    ('Carlos', 'Rodrigues', 42, '89012345678', '08-12-1980', 'carlos.rodrigues@example.com', '(51) 67890-1234', 'Cirurgião Bucomaxilofacial', 'CRM23456', 1),
    ('Fernanda', 'Lima', 33, '34567890123', '18-09-1989', 'fernanda.lima@example.com', '(61) 98765-4321', 'Odontopediatra', 'CRM34567', 9),
    ('Rafael', 'Martins', 36, '67890123456', '22-07-1986', 'rafael.martins@example.com', '(71) 12345-6789', 'Implantodontista', 'CRM45678', 3),
    ('Juliana', 'Almeida', 39, '90123456789', '05-11-1983', 'juliana.almeida@example.com', '(81) 87654-3210', 'Ortopedista Funcional dos Maxilares', 'CRM56789', 15),
    ('Bruno', 'Souza', 41, '12345678901', '14-02-1981', 'bruno.souza@example.com', '(91) 54321-0987', 'Dentística', 'CRM67890', 12),
    ('Luana', 'Cavalcante', 36, '23456789012', '18-11-1986', 'luana.cavalcante@example.com', '(99) 87654-3210', 'Odontologia Estética', 'CRM78901', 10),
    ('Gustavo', 'Pereira', 38, '34567890123', '27-03-1984', 'gustavo.pereira@example.com', '(92) 76543-2109', 'Ortodontia', 'CRM89012', 8),
    ('Luciana', 'Rocha', 41, '45678901234', '09-07-1981', 'luciana.rocha@example.com', '(93) 65432-1098', 'Implantodontia', 'CRM90123', 14);


-- Paciente
INSERT INTO Paciente (Nome, Sobrenome, Idade, CPF, DataDeAniversario, Email, NumeroDeTelefone, IdEndereco)
VALUES
    ('João', 'Silva', 35, '12345678901', '15-05-1987', 'joao.silva@example.com', '(11) 98765-4321', 10),
    ('Maria', 'Santos', 40, '98765432109', '20-10-1982', 'maria.santos@example.com', '(21) 12345-6789', 9),
    ('Pedro', 'Oliveira', 38, '45678901234', '12-08-1984', 'pedro.oliveira@example.com', '(31) 87654-3210', 5),
    ('Ana', 'Ferreira', 45, '23456789012', '25-03-1977', 'ana.ferreira@example.com', '(41) 54321-0987', 6),
    ('Carlos', 'Rodrigues', 42, '89012345678', '08-12-1980', 'carlos.rodrigues@example.com', '(51) 67890-1234', 1),
    ('Fernanda', 'Lima', 33, '34567890123', '18-09-1989', 'fernanda.lima@example.com', '(61) 98765-4321', 4),
    ('Rafael', 'Martins', 36, '67890123456', '22-07-1986', 'rafael.martins@example.com', '(71) 12345-6789', 7),
    ('Juliana', 'Almeida', 39, '90123456789', '05-11-1983', 'juliana.almeida@example.com', '(81) 87654-3210', 15),
    ('Bruno', 'Souza', 41, '12345678901', '14-02-1981', 'bruno.souza@example.com', '(91) 54321-0987', 12),
    ('Luana', 'Cavalcante', 36, '23456789012', '18-11-1986', 'luana.cavalcante@example.com', '(99) 87654-3210', 11),
    ('Gustavo', 'Pereira', 38, '34567890123', '27-03-1984', 'gustavo.pereira@example.com', '(92) 76543-2109', 8),
    ('Luciana', 'Rocha', 41, '45678901234', '09-07-1981', 'luciana.rocha@example.com', '(93) 65432-1098', 14);


INSERT INTO PacientePlano (IdPlano, IdPaciente, PlanoAtivo)
VALUES
    (1, 1, 1),
    (3, 3, 1),
    (5, 5, 1),
    (4, 7, 1),
    (5, 9, 1);

INSERT INTO PacienteProcedimento (IdPaciente, IdProcedimento, DataProcedimento, ProcedimentoRealizado)
VALUES
    (3, 7, GETDATE(), 1),
    (3, 2, GETDATE(), 1),
    (3, 3, GETDATE(), 1),
    (3, 4, GETDATE(), 1),
    (3, 6, GETDATE(), 1),
	(1, 7, GETDATE(), 1),
    (1, 2, GETDATE(), 1),
    (1, 3, GETDATE(), 1),
    (1, 4, GETDATE(), 1),
    (2, 6, GETDATE(), 1),
    (4, 6, GETDATE(), 1),
    (5, 6, GETDATE(), 1),
    (1, 6, GETDATE(), 1);
