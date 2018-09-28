using System;
using System.Collections.Generic;
namespace myApp
{
    class Column
    {
        public int nbFloor;
        public int nbElevators;
        public List<Elevator> elevatorsList; 
        public Column (int nbFloor, int nbElevators){
            this.nbFloor = nbFloor;
            this.nbElevators = nbElevators;
            this.elevatorsList = new List<Elevator> ();
            for (int i =0; i < this.nbElevators; i++) {
              elevatorsList.Insert(new Elevator(i + 1, this.nbFloor));
          
            
        }
    }
    class Button
    {
        public string direction;
        public int requestFloor;

        public Button (string direction, int requestFloor)
        {
           this.direction = direction;
           this.requestFloor = requestFloor;
           this.activateButton = false;
        } 
    }


    class InsideButton 
    {
       public int floor;
       public string status; 
       public InsideButton (int floor) 
       {
           this.floor = floor;
           this.status = 'desactivated';
       }
    }

    class ElevatorController
    {
       public int nbFloor;
       public List<button> buttonList; 
       public int nbElevators;
       public int selectedElevator;

       public ElevatorController(int nbFloor, int nbElevators)
       {
           this.nbFloor = nbFloor;
           this.nbElevators = nbElevators;
           this.column = new Column (int nbFloor, int nbElevators);
           this.buttonList = new List<button> ();
           //List<Button>.Insert(new  Button());
       }
       public void RequestElevator(int FloorNumber, string Direction)
       {
           int selectedElevator = this.FindElevator(int FloorNumber, string direction);
           selectedElevator.addFloorToList(int FloorNumber);
           selectedElevator.activateInsideButton(int FloorNumber);
           Console.WriteLine("Request Elevator on floor " + FloorNumber.ToString() + ", going " + Direction);
       }
       public void RequestFloor(string Elevator, string Direction)
       {
           Elevator.activateInsideButton(int FloorNumber);
           Elevator.addFloorToList(int FloorNumber);
           Elevator.moveNext();
           Console.WriteLine("Request Floor number " + FloorNumber.ToString() + ", going " + Direction);
       }

       public void FindElevator(int FloorNumber)
       {
            int distanceFloor = 999;
            int selectedElevator = null;
            for(int i = 0; i< this.column.elevatorsList.Count(); i++)
            {
            int differenceFloor = Math.abs(FloorNumber - this.column.elevatorsList[i].currentFloor);

            if (differenceFloor < distanceFloor){
                distanceFloor = differenceFloor;
                selectedElevator = this.column.elevatorList[i]
            
            }
            return selectedElevator;
       
           Console.WriteLine("FindElevator " + FloorNumber.ToString());
       }
    }

    
    class Elevator
    {
       public int elevatorNumber;
       public int nbFloor;
       public string status;
       public List<floor> floorList; 
       public Elevator(int elevatorNumber, int nbFloor)
       {
           this.elevatorNumber = elevatorNumber; 
           this.direction = "NONE";
           this.status = "idle";
           this.floorList = new List<floor> ();
           this.buttonList = new List<Button> ();

        for ( int i =0; i < nbFloor; i++)this.elevatorNumber = elevatorNumber; 
            this.buttonList = buttonList.Insert(new InsideButton(i));
        
            return currentFloor = 1; 
        }
       


       public void moveNext()
            let flooorList = new flooorList
            let FloorNumber = new
       {
           Console.WriteLine("MoveNext")
       }
       public void MoveDown(int FloorNumber )
       {
           Console.WriteLine("MoveDown" + FloorNumber.ToString() )
       }
       public void MoveUp(int FloorNumber )
       {
           Console.WriteLine("MoveUp"+ FloorNumber.ToString)
       }
       public void addFloorToList(int FloorNumber)
       {
           Console.WriteLine("addFloorToList" + FloorNumber.ToString() );
       }
       public void OpenDoor()
       {
           Console.WriteLine("OpenDoor");
       }
       public void CloseDoor()
       {
           Console.WriteLine("CloseDoor");
       }
       public void activateInsideButton(int FloorNumber)
       {
           Console.WriteLine("activateInsideButton" + FloorNumber.ToString() );
       }
    }
}
