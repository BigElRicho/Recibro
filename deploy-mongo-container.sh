# docker stop mongo
# docker rm mongo
# docker run -p 27018:27017 --name mongo -d mongo:8.0.3-noble
# echo -- docker container now running -- 

echo bringing containers down...
docker compose --profile dev down
echo bringing mongodb development containers up
docker compose --profile dev up -d
echo -- docker containers now running --
watch docker ps