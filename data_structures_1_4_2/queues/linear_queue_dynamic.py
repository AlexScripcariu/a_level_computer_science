# A program that implements the linear queue data structure in python
# This queue is dynamically sized

class Queue:
    """
    A class that implements a dynamically sized queue.
    """
    # constructor for the queue, can be initialised, or just empty
    def __init__(self, items: list = None):
        self.queue = items if items is not None else []

    def enqueue(self, item) -> None:
        """
        Adds an item to the end of the queue in O(1) time
        
        Parameters:
            item: the item to add to the end of the queue
        """
        self.queue.append(item)

    
    def dequeue(self):
        """
        A function that removes the item at the front of the queue and returns 
        it.

        Returns:
            front: The item at the beginning of the queue (index 0)
            None: If the queue is empty
        """

        if (len(self.queue) == 0):
            return None

        front = self.queue[0]
        self.queue = self.queue[1:] # removing the front item
        return front 


    def is_empty(self) -> bool:
        """Returns true if the queue is empty"""
        return True if (len(self.queue) == 0) else False 


# creating and testing the queues
def main():
    num_queue = Queue() # creating an empty queue
    num_queue.enqueue(1)
    num_queue.enqueue(2)
    print(num_queue.dequeue()) # Should return 1

    if (num_queue.is_empty()):
        print("The queue is empty!")
    else:
        print("The queue is not empty!") # expected output


main()
        


    
