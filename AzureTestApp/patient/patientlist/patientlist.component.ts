import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Patient } from '../patient.model';


@Component({
    selector: 'patientlist',
    templateUrl: './patientlist.component.html',
    providers: [DataService]
})
export class PatientListComponent implements OnInit {
    patients: Patient[] = [];

    constructor(private dataService: DataService) { }


    ngOnInit() {
        this.getpatients();
    }

    getpatients() {
        this.dataService.getpatients().subscribe(results => {
           this.patients = results.json() as Patient[];
       })
        
    }
}
