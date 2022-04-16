using System;

namespace _019Events
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um evento sempre é usado junto a um delegate*/
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();

        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }
    }

    public class Room
    {
        private int inUseSeats = 0;
        public int Seats { get; set; }

        public Room(int seats)
        {
            Seats = seats;
            inUseSeats = 0;
        }

        public void ReserveSeat()
        {
            inUseSeats++;
            if(inUseSeats >= Seats)
            {
                //evento fechado!
                OnRoonSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoonSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}
