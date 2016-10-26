from flask import jsonify, Blueprint, abort

from flask.ext.restful import (Resource, Api, reqparse,
                               inputs, fields, marshal,
                               marshal_with, url_for)

import models

course_fields = {
    'id': fields.Integer,
    'title': fields.String,
    'url': fields.String,
    'reviews': fields.List(fields.String)
}


def add_reviews(course):
    course.reviews = [url_for('resources.reviews.review', id=review.id)
                      for review in course.review_set]
    return course


def course_or_404(course_id):
    try:
        course = models.Course.get(models.Course.id==course_id)
    except models.Course.DoesNotExist:
        abort(404)
    else:
        return course


class CourseList(Resource):
    def __init__(self):
        self.reqparse = reqparse.RequestParser()
        self.reqparse.add_argument(
            'title',
            required=True,
            help='No course title provided',
            location=['form', 'json']
        )
        self.reqparse.add_argument(
            'url',
            required=True,
            help='No course URL provided',
            location=['form', 'json'],
            type=inputs.url
        )
        super().__init__()
        
    def get(self):
        courses = [marshal(add_reviews(course), course_fields)
                   for course in models.Course.select()]
        return {'courses': courses}
    
    @marshal_with(course_fields)
    def post(self):
        args = self.reqparse.parse_args()
        course = models.Course.create(**args)
        return (add_reviews(course), 201, {
                'Location': url_for('resources.courses.course', id=course.id)}
               )


class Course(Resource):
    def __init__(self):
        self.reqparse = reqparse.RequestParser()
        self.reqparse.add_argument(
            'title',
            required=True,
            help='No course title provided',
            location=['form', 'json']
        )
        self.reqparse.add_argument(
            'url',
            required=True,
            help='No course URL provided',
            location=['form', 'json'],
            type=inputs.url
        )
        super().__init__()

    @marshal_with(course_fields)
    def get(self, id):
        return add_reviews(course_or_404(id))
    
    def put(self, id):
        return jsonify({'title': 'Python Basics'})
    
    def delete(self, id):
        return jsonify({'title': 'Python Basics'})

courses_api = Blueprint('resources.courses', __name__)
api = Api(courses_api)
api.add_resource(
    CourseList,
    '/api/v1/courses',
    endpoint='courses'
)
api.add_resource(
    Course,
    '/api/v1/courses/<int:id>',
    endpoint='course'
)
