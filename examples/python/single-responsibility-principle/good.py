import sys
import os

sys.path.append(os.path.abspath(os.path.join(
    os.path.dirname(__file__), '..')
))

import math
import json
from matplotlib.pyplot import isinteractive
from models.Circle import Circle
from models.Square import Square


class AreaCalculator:
    def __init__(self, shapes: list):
        self.shapes = shapes

    def sum(self) -> float:
        
        sum_area = 0
        
        for shape in self.shapes:
            if isinstance(shape, Square):
                sum_area += shape.length**2
            if isinstance(shape, Circle):
                sum_area += math.pi*(shape.radius**2)
        
        return sum_area


class SumCalculatorOutputter:
    def __init__(self, calculator: AreaCalculator):
        self.calculator = calculator
    
    def JSON(self):
        return json.dumps({'sum': self.calculator.sum()}, sort_keys=True)        

    def Message(self) -> str:
        return f"Sum of the areas of provided shapes: {self.calculator.sum():.2f}"


'''
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
'''

shapes = [
  Circle(2),
  Square(5),
  Square(6),
]

areas = AreaCalculator(shapes)
output = SumCalculatorOutputter(areas)

print(output.JSON())
print(output.Message())



