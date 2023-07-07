<<<<<<< HEAD
﻿using Models.SCRO.Models.Paciente;
using SCRO.Controllers;
using SCRO.Models.Paciente;
using SCRO.SCRO.Models.Data;
using SCRO.SRCO.Views.Consulta;

Random random = new Random();

Paciente paciente1 = new Paciente(
    responsavel: 0,
    nome: "Ana Carolina Oliveira",
    idade: 21,
    cpf: 12345678901,
    rg: 12345678,
    celular: 31999999999,
    telefone: random.Next(100000000, 999999999),
    rua: "Avenida Prefeito Aracely de Paula, " ,
    numero: random.Next(1, 1000),
    bairro: "Centro",
    municipio: "Araxá",
    uf: "MG",
    cep: random.Next(10000000, 99999999),
    sexo: random.Next(2) == 0 ? 'M' : 'F',
    profissao: "Médica",
    email: "ana@example.com"
);

Paciente paciente2 = new Paciente(
    responsavel: 0,
    nome: "João da Silva",
    idade: random.Next(1, 100),
    cpf: random.Next(100000000, 999999999),
    rg: random.Next(100000000, 999999999),
    celular: random.Next(100000000, 999999999),
    telefone: random.Next(100000000, 999999999),
    rua: "Rua Antônio Sgarbi, ",
    numero: random.Next(1, 1000),
    bairro: "Loteamento Alto da Glória",
    municipio: "Sinop",
    uf: "MT",
    cep: random.Next(10000000, 99999999),
    sexo: random.Next(2) == 0 ? 'M' : 'F',
    profissao: "Programador",
    email: "joao@example.com"
);

Paciente paciente3 = new Paciente(
    responsavel: 0,
    nome: "Maria Fernandes",
    idade: random.Next(1, 100),
    cpf: random.Next(100000000, 999999999),
    rg: random.Next(100000000, 999999999),
    celular: random.Next(100000000, 999999999),
    telefone: random.Next(100000000, 999999999),
    rua: "Avenida Marte, " + random.Next(1, 1000),
    numero: random.Next(1, 1000),
    bairro: "Jardim Marco Zero",
    municipio: "Macapá",
    uf: "AP",
    cep: random.Next(10000000, 99999999),
    sexo: random.Next(2) == 0 ? 'M' : 'F',
    profissao: "Engenheira",
    email: "maria@example.com"
);

Paciente paciente4 = new Paciente(
    responsavel: 0,
    nome: "Pedro dos Santos",
    idade: random.Next(1, 100),
    cpf: random.Next(100000000, 999999999),
    rg: random.Next(100000000, 999999999),
    celular: random.Next(100000000, 999999999),
    telefone: random.Next(100000000, 999999999),
    rua: "Praça da República, ",
    numero: random.Next(1, 1000),
    bairro: "América",
    municipio: "Aracaju",
    uf: "SE",
    cep: random.Next(10000000, 99999999),
    sexo: random.Next(2) == 0 ? 'M' : 'F',
    profissao: "Engenheiro Civil",
    email: "santosPedro@example.com"
);



PacienteController paciente = new PacienteController();
//paciente.CadastrarPaciente(paciente1);
//paciente.CadastrarPaciente(paciente2);
//paciente.CadastrarPaciente(paciente3);
//paciente.CadastrarPaciente(paciente4);
//.BuscarPaciente(cpf: 123456789);
//paciente.BuscarTodos();

MenuInicialView.MenuInicial();
=======
﻿using SCRO.Controllers;
using SCRO.Models.Data;
using SCRO.Models.Paciente;
using SCRO.Views.Consulta;

Paciente felipe = new Paciente();
PacienteController controller = new PacienteController();   
controller.CadastrarPaciente(felipe);
>>>>>>> e123e002e728b9f57248bfd69ced289b95c70fd3
