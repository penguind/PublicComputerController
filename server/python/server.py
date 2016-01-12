#! /bin/python
# -*- coding:utf-8 -*-

import web

class index(object):
    """docstring for index"""
    def GET(self):
        return "Hello world!"

urls = (
    '/', 'index'
    )

if __name__ == "__main__":
    appweb = web.application(urls, globals())
    appweb.run()
        