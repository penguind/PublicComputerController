#! /bin/python
# -*- coding:utf-8 -*-

import web

class index(object):
    """docstring for index"""
    def __init__(self, arg):
        super(index, self).__init__()
        self.arg = arg

    def Get(self):
        return "Hello world!"

urls = (
    '/', index
    )

if __name__ == '__main__':
    web.application(urls, globals())
        