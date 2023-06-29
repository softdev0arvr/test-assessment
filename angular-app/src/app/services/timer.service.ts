import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { retry } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class TimerService {

    constructor(private http: HttpClient) { }

    rootURL = 'https://localhost:7297';

    getTime() {
        return this.http.get<TimerConfiguration>(`${this.rootURL}/Timer/Configure`).pipe(retry(1));
    }

    stopTimer() {
        return this.http.post(`${this.rootURL}/Timer/Stop`, {}).pipe(retry(1));
    }

}

export interface TimerConfiguration{
    interval: number;
    autoStart: boolean;
}