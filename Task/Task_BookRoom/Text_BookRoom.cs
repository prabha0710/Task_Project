namespace Task_BookRoom
{
	public static class RoomSeperation
	{
		public static string GuestRoomMethod(int nAdult, int nChildren)
		{
			int nTotalGuest = nAdult + nChildren;

			if(nAdult <= 0)
			{
				return "At least one adult must be present while booking a room.";
			}

			if(nTotalGuest > 16)
			{
				return "Only 16 people are allowed.";
			}

			return BookingRoom(nAdult, nChildren, nTotalGuest);
		}

		public static string BookingRoom(int nAdult, int nChildren, int nTotalGuest)
		{
			int nRooms = (nTotalGuest + 3) / 4;

			if(nRooms > 4)
			{
				return "A maximum of 4 rooms can be booked.";
			}

			if(nAdult < nRooms)
			{
				return "Not enough adults to fill all rooms.";
			}

			string result = "";
			int roomCount = 1;

			while(roomCount <= nRooms)
			{
				int adultsInRoom = 0;
				int childrenInRoom = 0;

				
				if(nAdult > 0)
				{
					adultsInRoom = 1; 
					nAdult--;
				}

				
				int remainingCapacity = 4 - adultsInRoom;

				
				while(remainingCapacity > 0 && nChildren > 0)
				{
					childrenInRoom++;
					nChildren--;
					remainingCapacity--;
				}

				
				while(remainingCapacity > 0 && nAdult > 0)
				{
					adultsInRoom++;
					nAdult--;
					remainingCapacity--;
				}

				
				nTotalGuest -= (adultsInRoom + childrenInRoom);

				
				result += $"Room {roomCount}: Adults {adultsInRoom} - Children {childrenInRoom}\n";
				roomCount++;
			}

			return result;
		}
	}
}
