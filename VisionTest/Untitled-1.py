#1.파이썬 3.8 버전 다운로드 후 -> cmd창에 cd C:\Python
#2.pip install ultralytics을 실행한 후 진행한다.

#ultralytics 라이브러리에서 YOLO 클래스를 임포트합니다.
from ultralytics import YOLO

import cv2
import torch

# LCOCO 데이터셋으로 사전 훈련된 YOLO11n 모델을 로드합니다.
model = YOLO("gasang99.pt")

# coco8.yaml 파일에 정의된 COCO8 데이터셋을 사용하여 모델을 100 에폭(epoch) 동안 훈련합니다. 
# imgsz=640은 훈련에 사용할 이미지의 크기를 640x640 픽셀로 설정합니다. 훈련 결과는 results 변수에 저장됩니다.
#results = model.train(data="coco8.yaml", epochs=100, imgsz=640)

# 파일 경로에 있는 사진으로 테스트할때 예시
#results = model("C:/Users/mjk12/OneDrive/바탕 화면/민준기/C#_Python_OpenCV4/Python_OpenCV4/datasets/coco8/images/train/000000000034.jpg", save=True, show=True)


# 웹캠 열기
cap = cv2.VideoCapture(0)

if not cap.isOpened():
    print("웹캠을 열 수 없습니다.")
    exit()

while True:
    # 프레임 읽기
    ret, frame = cap.read()
    if not ret:
        print("프레임을 읽을 수 없습니다.")
        break
    
     # YOLO 모델을 사용하여 물체 감지
    results = model(frame)

    # 결과를 이미지에 그리기
    frame = results[0].plot()  # results[0]에서 첫 번째 결과를 가져옵니다.

    # 프레임 표시
    cv2.imshow('Webcam', frame)

    # 'q' 키를 누르면 종료
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

# 웹캠 해제 및 모든 창 닫기
cap.release()
cv2.destroyAllWindows()