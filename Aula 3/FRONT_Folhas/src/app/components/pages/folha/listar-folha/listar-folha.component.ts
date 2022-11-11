import { Router, ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Funcionario } from 'src/app/models/Funcionario';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listar-folha',
  templateUrl: './listar-folha.component.html',
  styleUrls: ['./listar-folha.component.css']
})
export class ListarFolhaComponent implements OnInit {
  funcionarios!: Funcionario[];

  constructor(
    private http : HttpClient, 
    private router : Router, 
    private route: ActivatedRoute) {} 

  ngOnInit(): void {
    this.http.get<Funcionario[]>
    ("https://localhost:5001/api/funcionario/listar")
    // Execução da requisição
    .subscribe({
      next: (funcionarios) => {
        for (const funcionario in funcionarios) {
          console.log(funcionario)
          
        }
        this.funcionarios = funcionarios;
      }
    });
  }

}
