using System;
using System.Collections;
using System.Collections.Generic;


namespace Lecture9Iterator
{
	class MyList<T> : IEnumerable<T>
	{
		class MyNode
		{
			public T value;

			public MyNode next = null;


			public MyNode(T value, MyNode next = null)
			{
				this.value = value;
				this.next = next;
			}
		}


		public class Iterator : IEnumerator<T>
		{
			public T Current {
				get {
					if (current == null) {
						throw new InvalidOperationException();
					}

					return current.value;
				}
			}

			object IEnumerator.Current => (object) Current;

			private MyList<T> list;

			private MyNode current = null;


			public Iterator(MyList<T> list)
			{
				this.list = list;
			}


			public void Dispose()
			{
			}


			public bool MoveNext()
			{
				current = current == null ? list.head : current.next;
				return current != null;
			}


			public void Reset()
			{
				current = null;
			}
		}


		private MyNode head = null;


		public bool Empty
		{
			get { return head == null; }
		}


		public T First
		{
			get { return head.value; }
		}


		public bool Exists(T value)
		{
			MyNode node = head;

			while (node != null) {
				if (ValueEquals(node.value, value)) {
					return true;
				}

				node = node.next;
			}

			return false;
		}


		public IEnumerable<T> Items()
		{
			MyNode node = head;

			while (node != null) {
				yield return node.value;
				node = node.next;
			}
		}


		public void InsertFirst(T value)
		{
			head = new MyNode(value, head);
		}


		public bool InsertBefore(T value, T before)
		{
			MyNode next = head;
			MyNode previous = null;

			while (next != null) {
				if (ValueEquals(next.value, before)) {
					MyNode node = new MyNode(value, next);

					if (previous != null) {
						previous.next = node;
					} else {
						head = node;
					}

					return true;
				}

				previous = next;
				next = next.next;
			}

			return false;
		}


		public bool InsertAfter(T value, T after)
		{
			MyNode previous = head;

			while (previous != null) {
				if (ValueEquals(previous.value, after)) {
					MyNode node = new MyNode(value, previous.next);
					previous.next = node;
					return true;
				}

				previous = previous.next;
			}

			return false;
		}


		public void RemoveFirst()
		{
			head = head.next;
		}


		public bool Remove(T value)
		{
			MyNode next = head;
			MyNode previous = null;

			while (next != null) {
				if (ValueEquals(next.value, value)) {
					if (previous != null){
						previous.next = next.next;
					} else {
						head = next.next;
					}

					return true;
				}

				previous = next;
				next = next.next;
			}

			return false;
		}


		public IEnumerator<T> GetEnumerator()
		{
			return new Iterator(this);
		}
		

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


		private bool ValueEquals(T left, T right)
		{
			return left == null ?
				right == null :
				left.Equals(right);
		}
	}
}
