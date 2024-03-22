FROM eclipse-temurin:17-jdk-alpine

ARG JAR_FILE=./*.jar

COPY ${JAR_FILE} APP.jar 

ENTRYPOINT [ "java","-jar","/APP.jar" ]