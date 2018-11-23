export class Patient {
    constructor(
        public patientId?: number,
        public firstName?: string,
        public lastName?: string,
        public gender?: string,
        public dob?: Date,
        public state?: string,
        public city?: string
    ) { }
}