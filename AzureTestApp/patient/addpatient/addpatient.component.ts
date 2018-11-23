import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Patient } from '../patient.model';
import { State } from '../state.model';
import { City } from '../city.model';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';


@Component({
    selector: 'addpatient',
    templateUrl: './addpatient.component.html',
    providers: [DataService]
})
export class AddPatientComponent implements OnInit {

    private fieldArray: Array<Patient> = [];
    private newAttribute: any = {};

    states: State[] = [];
    cities: City[] = [];
    selectedState = 0;
    patientData: Patient = new Patient();
    submitted = false;
    genders = [
        'Male',
        'Female'];

    addPatientValue() {  
        // stop here if form is invalid
       
        this.dataService.savepatient(this.patientData)
    }

    constructor(private dataService: DataService) { }

    ngOnInit() {        
       this.getstates();
    }
    getstates() {
        this.dataService.getstates().subscribe(results => {
            this.states = results.json() as State[];
        })

    }

    changeCity(id: number) {
        this.selectedState = id;
        this.dataService.getcities(id).subscribe(results => {
            this.cities = results.json() as City[];
        })       
    }

    
}
