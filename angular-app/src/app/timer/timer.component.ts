import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { TimerConfiguration, TimerService } from '../services/timer.service';

@Component({
  selector: 'app-timer',
  templateUrl: './timer.component.html',
  styleUrls: ['./timer.component.css'],
})
export class TimerComponent {
  timerConfig: TimerConfiguration = { autoStart: false, interval: 0 };
  countdown: TimerConfiguration = { autoStart: false, interval: 0 };
  countdown1: TimerConfiguration = { autoStart: false, interval: 0 };
  hours: number = 0;
  minutes: number = 0;
  seconds: number = 0;
  minutes1: number = 0;
  seconds1: number = 0;
  isTimerRunning: boolean = false;
  isTimerRunning1: boolean = false;
  constructor(
    private toastr: ToastrService,
    private timerService: TimerService
  ) {}

  ngOnInit() {
    this.loadTimerConfiguration();
  }

  loadTimerConfiguration() {
    this.timerService.getTime().subscribe(
      (response) => {
        console.log('Response', response);
        this.timerConfig = response;
        this.isTimerRunning1 = true;
        this.countdown1 = response;
        if (this.timerConfig.autoStart == true) this.startTimer();
        // this.updateCountdown1();
      },
      (error) => {
        this.toastr.error('Failed to load timer configuration.');
        console.error(error);
      }
    );
  }

  startTimer() {
    this.timerService.getTime().subscribe(
      (response) => {
        this.timerConfig = response;
        this.isTimerRunning = true;
        this.countdown = response;
        this.toastr.success('Timer started.');

        this.updateCountdown();
      },
      (error) => {
        this.toastr.error('Failed to start timer.');
        console.error(error);
      }
    );
  }

  stopTimer() {
    this.timerService.stopTimer().subscribe(
      () => {
        this.isTimerRunning = false;
        this.toastr.success('Timer stopped.');
      },
      (error) => {
        this.toastr.error('Failed to stop timer.');
        console.error(error);
      }
    );
  }

  updateCountdown() {
    if (this.isTimerRunning && this.countdown.interval > 0) {
      setTimeout(() => {
        this.countdown.interval--;
        if (this.countdown.interval > 3600) {
          this.hours = Math.floor(this.countdown.interval / 3600);
          this.minutes = Math.floor(
            (this.countdown.interval - this.hours * 3600) / 60
          );
          this.seconds =
            this.countdown.interval - this.hours * 3600 - this.minutes * 60;
        } else if (this.countdown.interval > 60) {
          this.hours = 0;
          this.minutes = Math.floor(this.countdown.interval / 60);
          this.seconds = this.countdown.interval - this.minutes * 60;
        } else {
          this.hours = 0;
          this.minutes = 0;
          this.seconds = this.countdown.interval;
        }
        this.updateCountdown();
      }, 1000);
    } else {
      this.toastr.success('Countdown completed.');
      //Tell BE that timer has stopped
      this.timerService.stopTimer().subscribe(
        () => {
          this.isTimerRunning = false;
          this.countdown.interval = 0;
        },
        (error) => {
          this.toastr.error('Failed to stop timer.');
          console.error(error);
        }
      );
    }
  }
}
