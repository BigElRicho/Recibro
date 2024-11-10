docker stop mongo
docker rm mongo
docker run -p 27018:27017 --name mongo -d mongo:8.0.3-noble
echo -- docker container now running -- 