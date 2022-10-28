import { Funcionario } from './../../../../models/Funcionario';
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {
  nome!: string;
  cpf!: string;

  constructor() {}

  ngOnInit(): void {}

  cadastrar(): void {

    let funcionario: Funcionario = {
      nome: this.nome,
      cpf: this.cpf,
      email: "andore@kan.com",
      salario: 950,
      //criadoEm: "2022-01-25",
      nascimento: "1995-01-05",

    };
    console.log(funcionario);
  }
}
