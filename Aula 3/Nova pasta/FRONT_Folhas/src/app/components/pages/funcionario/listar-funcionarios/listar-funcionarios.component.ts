import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/models/Funcionario';

@Component({
  selector: 'app-listar-funcionarios',
  templateUrl: './listar-funcionarios.component.html',
  styleUrls: ['./listar-funcionarios.component.css']
})
export class ListarFuncionariosComponent implements OnInit {

  funcionarios!: Funcionario[];

  constructor(private http : HttpClient) {} 

  ngOnInit(): void {
    this.http.get<Funcionario[]>
    ("https://localhost:5001/api/funcionario/listar")
    // Execução da requisição
    .subscribe({
      next: (funcionarios) => {
        console.table(funcionarios);
      }
    });
  }

}
