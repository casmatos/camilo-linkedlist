Console.WriteLine("My own LikedList");

int[] arrayInts = new int[] { 1, 2, 3, 4, 5 };

CustomLinkedList<int> listLinkedSequencial = new();
CustomLinkedList<int> listLinkedReverse = new();

foreach (int item in arrayInts)
{
    listLinkedSequencial.AddFirst(item);
}

foreach (int item in arrayInts)
{
    listLinkedReverse.AddLast(item);
}
