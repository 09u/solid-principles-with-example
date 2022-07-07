import abc

class ManageShapeInterface(metaclass=abc.ABCMeta):
    def calculate(self)->float:
        raise NotImplementedError
