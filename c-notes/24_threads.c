#include <stdio.h>
#include <pthread.h>
#include <unistd.h> // for usleep

#define NUM_THREADS 4
#define PROCESS_DURATION_MS 1000

void* threadFunction(void* arg) {
    int threadId = *((int*)arg);
    printf("Thread %d is running\n", threadId);

    // Simulate process by sleeping for a duration
    usleep(PROCESS_DURATION_MS * 1000);

    printf("Thread %d has finished\n", threadId);
    return NULL;
}

int main() {
    pthread_t threads[NUM_THREADS];
    int threadIds[NUM_THREADS];

    // Create threads
    for (int i = 0; i < NUM_THREADS; i++) {
        threadIds[i] = i;
        pthread_create(&threads[i], NULL, threadFunction, &threadIds[i]);
    }

    // Wait for threads to finish
    for (int i = 0; i < NUM_THREADS; i++) {
        pthread_join(threads[i], NULL);
    }

    printf("All threads have finished\n");

    return 0;
}