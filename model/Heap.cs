using System;
using System.Collections.Generic;

public class Heap<T>
{
	private T[] tree;
	private int heapSize;
	private IComparer<T> comp;

	public Heap(IComparer<T> comp)
	{
		this.comp = comp;
	}

	public int Left(int index) {
		return 2*index + 1;
	}
	
	public int Right(int index) {
		return 2*(index+1);
	}
	
	public int Parent(int index) {
		if(index == 0) { //root does not have a Parent
			return Int32.MinValue;
		}
		return (index - 1)/2;
	}
	
	//max seria min si se inicializo como un min-heap
	public void Heapify(int index) {
		int l = Left(index);
		int r = Right(index);
		int max = index;
		if(l < heapSize && comp.Compare(tree[l], tree[max]) > 0) {
			max = l;
		}
		if(r < heapSize && comp.Compare(tree[r], tree[max]) > 0) {
			max = r;
		}
		
		T current = tree[index];
		if(comp.Compare(tree[max], current) != 0) {
			tree[index] = tree[max];
			tree[max] = current;
			Heapify(max);
		}
	}
	
	public T[] GetTree() {
		return tree;
	}

	public void BuildHeap(T[] array) {
		int firstInnerNode = Parent(tree.Length-1);
		heapSize = tree.Length;
		while(firstInnerNode > -1) {
			Heapify(firstInnerNode);
			firstInnerNode--;
		}
	}

	public void HeapSort(T[] array)
	{
		SetTree(array); //llamada implicita a BuildHeap
		T[] tarray = GetTree();
		for (int i = tarray.Length - 1; i > 0; i--)
		{ //desde
			T root = tarray[0];
			tarray[0] = tarray[heapSize - 1];
			tarray[heapSize - 1] = root;
			heapSize--;
			Heapify(0);
		}
	}

	public void HeapSort(T[] array, IComparer<T> comp) {
		 Heap<T> h = new Heap<T>(comp);
		 h.SetTree(array); //llamada implicita a BuildHeap
		 T[] tarray = h.GetTree();
		 for (int i = tarray.Length - 1; i > 0; i--) { //desde
			T root = tarray[0];
			tarray[0] = tarray[h.heapSize-1];
			tarray[h.heapSize-1] = root;
			h.heapSize--;
			h.Heapify(0);
		}
	}
	
	public T ExtractRoot() {
		if(heapSize < 1) {
			throw new Exception("Underflow");
		}
		T root = tree[0];
		tree[0] = tree[heapSize-1];
		heapSize--;
		Heapify(0);
		return root;
	}
	
	public void IncreaseKey(int index, T key){
		if(comp.Compare(key, tree[index]) < 0) {
			throw new Exception("key is less than current key");
		}
		tree[index] = key;
		while(index > 0 && comp.Compare(tree[Parent(index)], tree[index]) < 0) {
			T p = tree[Parent(index)];
			tree[Parent(index)] = tree[index];
			tree[index] = p;
			index = Parent(index);
		}
	}
	
	public void heapInsert(T key) {
		heapSize++;
		tree[heapSize-1] = key; //el menor de los menores o el mayor de los mayores, segun sea el caso
		IncreaseKey(heapSize - 1, key);
	}
	
	//TODO use buil-heap
	public void SetTree(T[] array) {
		tree = array;
		BuildHeap(tree);
	}

	public int GetHeapSize() {
		return heapSize;
	}

	public void SetHeapSize(int heapSize) {
		this.heapSize = heapSize;
	}

	public IComparer<T> GetComp() {
		return comp;
	}

	public void SetComp(IComparer<T> comp) {
		this.comp = comp;
	}	
}
