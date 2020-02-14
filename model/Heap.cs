﻿using System;

public class Heap<E>
{
	private E[] tree;
	private int heapSize;
	private Icomparer<E> comp;

	public Heap(Icomparer<E> comp)
	{
		this.comp = comp;
	}

	public int left(int index) {
		return 2*index + 1;
	}
	
	public int right(int index) {
		return 2*(index+1);
	}
	
	public int parent(int index) {
		if(index == 0) { //root does not have a parent
			return Integer.MIN_VALUE;
		}
		return (index - 1)/2;
	}
	
	//max seria min si se inicializo como un min-heap
	public void heapify(int index) {
		int l = left(index);
		int r = right(index);
		int max = index;
		if(l < heapSize && comp.compare(tree[l], tree[max]) > 0) {
			max = l;
		}
		if(r < heapSize && comp.compare(tree[r], tree[max]) > 0) {
			max = r;
		}
		
		E current = tree[index];
		if(comp.compare(tree[max], current) != 0) {
			tree[index] = tree[max];
			tree[max] = current;
			heapify(max);
		}
	}
	
	public E[] getTree() {
		return tree;
	}

	public void buildHeap(E[] array) {
		int firstInnerNode = parent(tree.length-1);
		heapSize = tree.length;
		while(firstInnerNode > -1) {
			heapify(firstInnerNode);
			firstInnerNode--;
		}
	}
	
	public static void HeapSort(T[] array, Comparator<T> comp) {
		 Heap<T> h = new Heap<T>(comp);
		 h.setTree(array); //llamada implicita a buildHeap
		 T[] tarray = h.getTree();
		 for (int i = tarray.length-1; i > 0; i--) { //desde
			T root = tarray[0];
			tarray[0] = tarray[h.heapSize-1];
			tarray[h.heapSize-1] = root;
			h.heapSize--;
			h.heapify(0);
		}
	}
	
	public E extractRoot() {
		if(heapSize < 1) {
			throw new Exception("Underflow");
		}
		E root = tree[0];
		tree[0] = tree[heapSize-1];
		heapSize--;
		heapify(0);
		return root;
	}
	
	public void increaseKey(int index, E key){
		if(comp.compare(key, tree[index]) < 0) {
			throw new Exception("key is less than current key");
		}
		tree[index] = key;
		while(index > 0 && comp.compare(tree[parent(index)], tree[index]) < 0) {
			E p = tree[parent(index)];
			tree[parent(index)] = tree[index];
			tree[index] = p;
			index = parent(index);
		}
	}
	
	public void heapInsert(E key) {
		heapSize++;
		tree[heapSize-1] = key; //el menor de los menores o el mayor de los mayores, segun sea el caso
		increaseKey(heapSize - 1, key);
	}
	
	//TODO use buil-heap
	public void setTree(E[] array) {
		tree = array;
		buildHeap(tree);
	}

	public int getHeapSize() {
		return heapSize;
	}

	public void setHeapSize(int heapSize) {
		this.heapSize = heapSize;
	}

	public Comparator<E> getComp() {
		return comp;
	}

	public void setComp(Comparator<E> comp) {
		this.comp = comp;
	}	
}
