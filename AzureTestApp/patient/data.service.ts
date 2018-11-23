import { Injectable, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Patient } from './patient.model';


@Injectable()
export class DataService {

    private urlPatientList = "/api/getpatients";
    private urlStateList = "/api/getstates";
    private urlCityList = "/api/getcities";
    private urlSavePatient = "/api/savepatient";

   
    patients: Patient[] =[];
    constructor(private _service: Http) {
    }

    getpatients() {
        return this._service.get(this.urlPatientList);
    }

    getstates() {
        return this._service.get(this.urlStateList);
    }
    getcities(id: number) {
        return this._service.get(this.urlCityList +"/"+ id);
    }

    savepatient(patientData: Patient) {
        return this._service.post(this.urlSavePatient, patientData);
    }

}