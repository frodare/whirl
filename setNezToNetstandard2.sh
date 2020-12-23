#!/bin/bash

cd Nez

find . -path Tests -prune -o -name 'Nez*.csproj' | grep -v Tests | grep -v Pipeline | xargs perl -pi -e 's/net471/netstandard2.0/g'

