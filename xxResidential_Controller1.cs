using System;
using System.Collections.Generic;
namespace Rocket_Elevators_Controllers {
    class Program
    {
        static void Main(string[] args)
        {
            var elevatorController = new ElevatorController(10, 2);
			elevatorController.RequestElevator(1, "Up");
			elevatorController.RequestFloor(1, "Down");
        }
    }

	class Column {
		public int nbFloor;
		public int nbElevators;
		public List < Elevator > elevatorsList;
		public Column(int nbFloor, int nbElevators) {
			this.nbFloor = nbFloor;
			this.nbElevators = nbElevators;
			List < Elevator > elevatorsList = new ElevatorController (10,2);
			for (int i = 0; i < this.nbElevators; i++) {
				elevatorsList.Add(new Elevator(i + 1, this.nbFloor));
			}
		}
	}
	class Button {
		public string direction;
		public int requestFloor;
		public Button(string direction, int requestFloor) {
			this.direction = direction;
			this.requestFloor = requestFloor;
			this.activate_button = false;
		}
	}
	class InsideButton {
		public int floor;
		public string status;
		public InsideButton(int floor) {
			this.floor = floor;
			this.status = "desactivated";
		}
	}
	class ElevatorController {
		public int nbFloor;
		public int nbElevators;
		public List < Button > buttonList;
		public Column column;
		public int selectedElevator;
		public ElevatorController(int nbFloor, int nbElevators) {
			this.nbFloor = nbFloor;
			this.nbElevators = nbElevators;
			this.column = new Column(nbFloor, nbElevators);
			this.button_list = new List < Button > ();
		}
		public void RequestElevator(int FloorNumber, string Direction) {
			int selectedElevator = this.FindElevator(FloorNumber, Direction);
			selectedElevator.addFloorToList(FloorNumber);
			selectedElevator.activateInsideButton(FloorNumber);
			Console.WriteLine("Request Elevator on floor " + FloorNumber.ToString() + ", going " + Direction);
		}
		public void RequestFloor(int Elevator, string Direction) {
			Elevator.activateInsideButton(FloorNumber);
			Elevator.addFloorToList(FloorNumber);
			Elevator.moveNext();
			Console.WriteLine("Request Floor number " + FloorNumber.ToString() + ", going " + Direction);
		}
		public void FindElevator(int FloorNumber) {
			int distanceFloor = 999;
			int selectedElevator = null;
			for (int i = 0; i < this.column.elevatorsList.Count; i++) {
				int differenceFloor = Math.abs(FloorNumber - this.column.elevatorList[i].currentFloor);
				if (differenceFloor < distanceFloor) {
					distanceFloor = differenceFloor;
					selectedElevator = this.column.elevatorList[i];
				}
				return selectedElevator;
				Console.WriteLine("FindElevator " + FloorNumber);
			}
		}

	}

	class Elevator {
			public int elevatorNumber;
			public int nbFloor;
			public string status;
			public int current_floor;
			public List < floor > floorList;
			public Elevator(int elevatorNumber, int nbFloor) {
				this.elevatorNumber = elevatorNumber;
				this.direction = "NONE";
				this.status = "idle";
				this.floorList = new List < floor > ();
				this.buttonList = buttonList.push(new Button());
				for (int i = 0; i < nbFloor; i++) {
					buttonList.push(new Button());
				}
				return current_floor = 1;
			}
			public void move_next() {
				var FloorNumber = this.floor_list.pop();
				if (this.current_floor > FloorNumber) {
					this.moveDown(FloorNumber);
				}
				else if (this.current_floor < FloorNumber) {
					this.moveUp(FloorNumber);
				}
				else {
					this.OpenDoor();
				}
			}

			public void moveDown(int FloorNumber) {
				this.direction = "down";
				this.status = "Moving";
				console.writeLIne("Elevator is going down");

				var interval = setInterval(() =>{
					this.current_floor = this.current_floor - 1;
					console.writeLine(this.current_floor);
					if (this.current_floor == FloorNumber) {
						clearInterval(interval);
						console.writeLine("Arrived at floor " + this.current_floor);
						this.OpenDoor();
					}
				},
				1000);
			}
			public void moveUp(int FloorNumber) {
				this.direction = "up";
				this.status = "Moving";
				console.writeLIne("Elevator is going up");
				var interval = setInterval(() => {
					this.current_floor = this.current_floor + 1;
					console.writeLine(this.current_floor);
					if (this.current_floor == FloorNumber) {
						clearInterval(interval);
						console.writeLine("Arrived at floor " + this.current_floor);
						this.OpenDoor();
					}
				},
				1000);
			}
			public void addFloorToList(int FloorNumber) {
				this.floor_list.push(FloorNumber);
				if (this.direction == "up") {
					this.floor_list.sort();
					console.writeLine(this.floor_list);
				}
				else if (this.direction == "down") {
					this.floor_list.sort().reverse();
					console.writeLine(this.floor_list);
				}
			}

			public void OpenDoor() {
				console.writeLine("Opening door on floor " + this.current_floor);
				this.status = "open_door";
				setTimeout(() => {
					this.closeDoor();
				},
				5000);
			}

			public void closeDoor() {
				console.writeLine("Closing door");
				this.status = "close_door";
				if (this.floor_list.Count() > 0) {
					this.move_next();
				}
			}

			public void activateInsideButton(int FloorNumber) {
				console.writeLine("Activated button at floor " + FloorNumber);
				if (this.request_floor == this.floor_list) {
					this.activate_InsideButton = false;
				}
				if (this.request_floor < this.floor_list) {
					this.moveUp();
				}
				else if (this.request_floor > this.floor_list) {
					this.moveDown();
				}
			}

		}
}