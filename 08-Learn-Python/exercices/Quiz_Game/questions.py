class Question:
    answer = None
    text = None
    

class Add(Question):
    def __init__(self, num1, num2):
        self.text = '{} + {}'.format(num1, num2)
        self.answer = num1 + num2
        
        
class Multiply(Question):
    def __init__(self, num1, num2):
        self.text = '{} x {}'.format(num1, num2)
        self.answer = num1 * num2
