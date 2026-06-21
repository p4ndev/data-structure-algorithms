#include <stdio.h>
#include <stdlib.h>

typedef struct ListNode {
    int val;
    struct ListNode* next;
} ListNode;

ListNode* reverseList(ListNode* head) {

    ListNode* prev = NULL;
    ListNode* curr = head;

    while (curr != NULL) {
        ListNode* temp = curr->next;
        curr->next = prev;
        prev = curr;
        curr = temp;
    }

    return prev;
}

int main()
{
    ListNode* input = malloc(sizeof(ListNode));
    input->val = 1;

    input->next = malloc(sizeof(ListNode));
    input->next->val = 2;

    input->next->next = malloc(sizeof(ListNode));
    input->next->next->val = 3;

    input->next->next->next = malloc(sizeof(ListNode));
    input->next->next->next->val = 4;

    input->next->next->next->next = malloc(sizeof(ListNode));
    input->next->next->next->next->val = 5;

    input->next->next->next->next->next = NULL;

    ListNode* output = reverseList(input);

    while (output != NULL) {
        printf("%d ", output->val);
        output = output->next;
    }

    printf("\n");

    return 0;
}
