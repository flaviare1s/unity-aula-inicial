using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public string title;
    public string author;

    void Start()
    {
        Book myBook = new Book();
        myBook.title = "The Lord of the Rings";
        myBook.author = "J. R. R. Tolkien";

        Debug.Log("Book: " + myBook.title + " by " + myBook.author);
    }
}
