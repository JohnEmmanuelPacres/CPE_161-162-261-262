#include <stdio.h>

// Define a struct to represent progress data
typedef struct {
    int quizScores[10]; // Example: Array to store quiz scores
    float studyTime;    // Example: Total study time in hours
} ProgressData;

// Function to update quiz scores
void updateQuizScore(ProgressData *progress, int quizNumber, int score) {
    if (quizNumber >= 0 && quizNumber < 10) {
        progress->quizScores[quizNumber] = score;
    }
}

// Function to update study time
void updateStudyTime(ProgressData *progress, float hours) {
    progress->studyTime += hours;
}

int main() {
    ProgressData userProgress = { {0}, 0.0 }; // Initialize progress data

    // Update progress data
    updateQuizScore(&userProgress, 0, 80); // Update quiz 0 score to 80
    updateQuizScore(&userProgress, 1, 75); // Update quiz 1 score to 75
    updateStudyTime(&userProgress, 2.5);   // Add 2.5 hours to study time

    // Display progress data
    printf("Quiz Scores:\n");
    for (int i = 0; i < 10; i++) {
        printf("Quiz %d: %d\n", i, userProgress.quizScores[i]);
    }
    printf("Total Study Time: %.1f hours\n", userProgress.studyTime);

    return 0;
}
