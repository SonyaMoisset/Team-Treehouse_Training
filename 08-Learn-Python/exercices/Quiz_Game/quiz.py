import datetime
import random

from questions import Add, Multiply


class Quiz:
    questions = []
    answers = []
    
    def __init__(self):
        question_types = (Add, Multiply)
        # generate 10 random questions with numbers from 1 to 10
        for _ in range(10):
            num1 = random.randint(1, 10)
            num2 = random.randint(1, 10)
            question = random.choice(question_types)(num1, num2)
            # add these questions into self.questions
            self.questions.append(question)
        
    def take_quiz(self):
        # log the start time
        self.start_time = datetime.datetime.now()
        
        # ask all of the questions
        for question in self.questions:
            # log if they got the question right
            self.answers.append(self.ask(question))
        else:
            # log the end time
            self.end_time = datetime.datetime.now()
        
        # show a summary
        return self.summary()
        

    def ask(self, question):
        correct = False
        # log the start time
        question_start = datetime.datetime.now()
        
        # capture the answer
        answer = input(question.text + ' = ')
        
        # check the answer
        if answer == str(question.answer):
            correct = True
            
        # log the end time
        question_end = datetime.datetime.now()
        
        # if the answer's right, send back True
        # otherwise, send back False
        # send back the elapsed time, too
        return correct, question_end - question_start
        
    def total_correct(self):
        # return the total # of correct answers
        total = 0
        for answer in self.answers:
            if answer[0]:
                total += 1
        return total
        
    def summary(self):
        # print how many you got right and the total # of questions. 5/10
        print("You got {} out of {} right.".format(
                self.total_correct(), len(self.questions)
        ))
        # print the total time for the quiz: 30 seconds!
        print("It took you {} seconds total.".format(
                (self.end_time-self.start_time).seconds
        ))
        

Quiz().take_quiz()
