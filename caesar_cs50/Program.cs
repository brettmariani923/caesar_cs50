#include < cs50.h >
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, string argv[])
{

    if (argc != 2)
    {
        printf("Usage: ./ceasar key\n");
        return 1;
    }

    string keyString = argv[1];

    for (int i = 0; i < strlen(keyString); i++)
    {
        if (!isdigit(keyString[i]))
        {
            printf("Usage: ./caesar key\n");
            return 1;
        }
    }

    int key = atoi(keyString);
    string plainText = get_string("plaintext:  ");

    printf("ciphertext: ");

    for (int i = 0; i < strlen(plainText); i++)
    {
        char x = plainText[i];

        if (isupper(x))
        {
            char cypher = ((x - 'A' + key) % 26) + 'A';
            printf("%c", cypher);
        }

        else if (islower(x))
        {
            char cypher = ((x - 'a' + key) % 26) + 'a';
            printf("%c", cypher);
        }

        else
        {
            printf("%c", x);
        }
    }

    printf("\n");
    return 0;
}
