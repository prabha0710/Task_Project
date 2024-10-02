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

			string strresult = "";
			int nroomCount = 1;

			while(nroomCount <= nRooms)
			{
				int nadultsRoomCount = 0;
				int nchildrenRoomCount = 0;

				
				if(nAdult > 0)
				{
					nadultsRoomCount = 1; 
					nAdult--;
				}

				
				int nChildrenNeedCount = 4 - nadultsRoomCount;

				
				while(nChildrenNeedCount > 0 && nChildren > 0)
				{
					nchildrenRoomCount++;
					nChildren--;
					nChildrenNeedCount--;
				}

				
				while(nChildrenNeedCount > 0 && nAdult > 0)
				{
					nadultsRoomCount++;
					nAdult--;
					nChildrenNeedCount--;
				}

				
				nTotalGuest -= (nadultsRoomCount + nchildrenRoomCount);

				
				strresult += $"Room {nroomCount}: Adults {nadultsRoomCount} - Children {nchildrenRoomCount}\n";
				nroomCount++;
			}

			return strresult;
		}
	}
}
