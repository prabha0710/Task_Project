using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Task_BookRoom;

namespace Task.Test
{
	[TestClass]
	public class BookRoomText
	{
		[TestMethod]
		public void TestBookRooms_3A_5C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(3, 5);
			Assert.AreEqual("Room 1: Adults 1 - Children 3\nRoom 2: Adults 2 - Children 2\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_4A_5C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(4, 5);
			Assert.AreEqual("Room 1: Adults 1 - Children 3\nRoom 2: Adults 2 - Children 2\nRoom 3: Adults 1 - Children 0\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_4A_6C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(4, 6);
			Assert.AreEqual("Room 1: Adults 1 - Children 3\nRoom 2: Adults 1 - Children 3\nRoom 3: Adults 2 - Children 0\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_3A_8C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(3, 8);
			Assert.AreEqual("Room 1: Adults 1 - Children 3\nRoom 2: Adults 1 - Children 3\nRoom 3: Adults 1 - Children 2\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_1A_0C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(1, 0);
			Assert.AreEqual("Room 1: Adults 1 - Children 0\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_1A_1C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(1, 1);
			Assert.AreEqual("Room 1: Adults 1 - Children 1\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_4A_0C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(4, 0);
			Assert.AreEqual("Room 1: Adults 4 - Children 0\n", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_0A_0C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(0, 0);
			Assert.AreEqual("At least one adult must be present while booking a room.", strMessage);
		}

		[TestMethod]
		public void TestBookRooms_2A_8C()
		{
			string strMessage = RoomSeperation.GuestRoomMethod(2, 8);
			Assert.AreEqual("Not enough adults to fill all rooms.", strMessage);
		}

	}
}



